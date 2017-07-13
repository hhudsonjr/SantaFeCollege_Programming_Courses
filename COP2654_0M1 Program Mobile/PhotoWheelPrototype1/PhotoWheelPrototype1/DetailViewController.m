//
//  DetailViewController.m
//  PhotoWheelPrototype1
//
//  Created by HansulHudson on 10/28/13.
//  Copyright (c) 2013 HansulHudson. All rights reserved.
//

#import "DetailViewController.h"
#import "CustomCell.h"
#import "PhotoWheelViewCell.h"

@interface DetailViewController ()
@property (strong, nonatomic) NSArray *data;
@property (strong, nonatomic) PhotoWheelViewCell *selectedPhotoWheelViewCell;
@property (strong, nonatomic) UIPopoverController *masterPopoverController;
@property (strong, nonatomic) UIActionSheet *actionSheet;
@property (strong, nonatomic) UIImagePickerController *imagePickerController;
@property (strong, nonatomic) UIPopoverController *imagePickerPopoverController;

- (void)configureView;

@end

@implementation DetailViewController

- (void)willRotateToInterfaceOrientation:(UIInterfaceOrientation)
toInterfaceOrientation duration:(NSTimeInterval)duration
{
    if ([self actionSheet]) {
        [[self actionSheet] dismissWithClickedButtonIndex:-1 animated:YES];
    }
}

#pragma mark - Managing the detail item

- (void)setDetailItem:(id)newDetailItem
{
    if (_detailItem != newDetailItem) {
        _detailItem = newDetailItem;
        
        // Update the view.
        [self configureView];
    }

    if (self.masterPopoverController != nil) {
        [self.masterPopoverController dismissPopoverAnimated:YES];
    }        
}

- (void)configureView
{
    // Update the user interface for the detail item.

    if (self.detailItem) {
        self.detailDescriptionLabel.text = [self.detailItem description];
    }
}

- (void)viewDidLoad
{
    [super viewDidLoad];
	// Do any additional setup after loading the view, typically from a nib.
    [self configureView];
    
    UINib *nib = [UINib nibWithNibName:@"CustomCell" bundle:nil];
    [[self collectionView] registerNib:nib forCellWithReuseIdentifier:@"CustomCell"];
    [[self collectionView] setHidden:YES];
    
    UIImage *defaultPhoto = [UIImage imageNamed:@"defaultPhoto.png"];
    CGRect cellFrame = CGRectMake(0, 0, 75, 75);
    NSInteger count = 10;
    NSMutableArray *newArray = [[NSMutableArray alloc] initWithCapacity:count];
    for (NSInteger index = 0; index < count; index++) {
        PhotoWheelViewCell *cell =
        [[PhotoWheelViewCell alloc] initWithFrame:cellFrame];
        [cell setImage:defaultPhoto];
        
        // Add a double-tap gesture to the cell.
        UITapGestureRecognizer *doubleTap;
        doubleTap = [[UITapGestureRecognizer alloc]
                     initWithTarget:self
                     action:@selector(cellDoubleTapped:)];
        
        [doubleTap setNumberOfTapsRequired:2];
        [cell addGestureRecognizer:doubleTap];
        
        // Add a single-tap gesture to the cell.
        UITapGestureRecognizer *tap = [[UITapGestureRecognizer alloc]
                                       initWithTarget:self
                                       action:@selector(cellTapped:)];
        [tap requireGestureRecognizerToFail:doubleTap];
        [cell addGestureRecognizer:tap];
        
        [newArray addObject:cell];
    }
    [self setData:[newArray copy]];
    
    NSArray *segmentedItems = @[@"Wheel", @"Carousel", @"Flow"];
    UISegmentedControl *segmentedControl = [[UISegmentedControl alloc]
                                            initWithItems:segmentedItems];
    [segmentedControl addTarget:self
                         action:@selector(segmentedControlValueChanged:)
               forControlEvents:UIControlEventValueChanged];
    [segmentedControl setSegmentedControlStyle:UISegmentedControlStyleBar];
    [segmentedControl setSelectedSegmentIndex:0];
    [[self navigationItem] setTitleView:segmentedControl];
}

- (void)segmentedControlValueChanged:(id)sender
{
    NSInteger index = [sender selectedSegmentIndex];
    if (index == 0) {
        [[self collectionView] setHidden:YES];
        [[self wheelView] setHidden:NO];
        [[self wheelView] setStyle:WheelViewStyleWheel];
    } else if (index == 1) {
        [[self collectionView] setHidden:YES];
        [[self wheelView] setHidden:NO];
        [[self wheelView] setStyle:WheelViewStyleCarousel];
    } else {
        [[self collectionView] setHidden:NO];
        [[self wheelView] setHidden:YES];
    }
}

#pragma mark - UICollectionViewDataSource and UICollectionViewDelegate

- (NSInteger)collectionView:(UICollectionView *)collectionView
     numberOfItemsInSection:(NSInteger)section
{
    return 1000;
}

- (UICollectionViewCell *)collectionView:(UICollectionView *)collectionView
                  cellForItemAtIndexPath:(NSIndexPath *)indexPath
{
    CustomCell *cell =
    [collectionView dequeueReusableCellWithReuseIdentifier:@"CustomCell"
                                              forIndexPath:indexPath];
    [[cell contentView] setBackgroundColor:[UIColor blueColor]];
    
    NSString *text = [NSString stringWithFormat:@"%i", [indexPath item]];
    [[cell labelText] setText:text];
    
    return cell;
}

- (void)collectionView:(UICollectionView *)collectionView
didSelectItemAtIndexPath:(NSIndexPath *)indexPath
{
    UICollectionViewCell *cell =
    [collectionView cellForItemAtIndexPath:indexPath];
    [[cell contentView] setBackgroundColor:[UIColor yellowColor]];
}

- (void)collectionView:(UICollectionView *)collectionView
didDeselectItemAtIndexPath:(NSIndexPath *)indexPath
{
    UICollectionViewCell *cell =
    [collectionView cellForItemAtIndexPath:indexPath];
    [[cell contentView] setBackgroundColor:[UIColor blueColor]];
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

- (id)initWithNibName:(NSString *)nibNameOrNil bundle:(NSBundle *)nibBundleOrNil
{
    self = [super initWithNibName:nibNameOrNil bundle:nibBundleOrNil];
    if (self) {
        self.title = NSLocalizedString(@"Detail", @"Detail");
        
        [self setImagePickerController:[[UIImagePickerController alloc] init]];
        [[self imagePickerController] setDelegate:self];
    }
    return self;
}
							
#pragma mark - Split view

- (void)splitViewController:(UISplitViewController *)splitController willHideViewController:(UIViewController *)viewController withBarButtonItem:(UIBarButtonItem *)barButtonItem forPopoverController:(UIPopoverController *)popoverController
{
    barButtonItem.title = NSLocalizedString(@"Albums", @"Albums");
    [self.navigationItem setLeftBarButtonItem:barButtonItem animated:YES];
    self.masterPopoverController = popoverController;
}

- (void)splitViewController:(UISplitViewController *)splitController willShowViewController:(UIViewController *)viewController invalidatingBarButtonItem:(UIBarButtonItem *)barButtonItem
{
    // Called when the view is shown again in the split view, invalidating the button and popover controller.
    [self.navigationItem setLeftBarButtonItem:nil animated:YES];
    self.masterPopoverController = nil;
}

#pragma mark - WheelViewDataSource methods

- (NSInteger)wheelViewNumberOfCells:(WheelView *)wheelView
{
    NSInteger count = [[self data] count];
    return count;
}

- (WheelViewCell *)wheelView:(WheelView *)wheelView
                 cellAtIndex:(NSInteger)index
{
    WheelViewCell *cell = [[self data] objectAtIndex:index];
    return cell;
}

- (void)cellDoubleTapped:(UIGestureRecognizer *)recognizer
{
    NSLog(@"%s", __PRETTY_FUNCTION__);
}

- (void)cellTapped:(UIGestureRecognizer *)recognizer
{
    [self setSelectedPhotoWheelViewCell:(PhotoWheelViewCell *)[recognizer view]];
    
    BOOL hasCamera = [UIImagePickerController isSourceTypeAvailable:
                      UIImagePickerControllerSourceTypeCamera];
    if (hasCamera) {
        [self presentPhotoPickerMenu];
    } else {
        [self presentPhotoLibrary];
    }
}

- (void)presentPhotoLibrary
{
    // Display assets from the Photos library only.
    UIImagePickerController *imagePicker = [self imagePickerController];
    [imagePicker setSourceType:UIImagePickerControllerSourceTypePhotoLibrary];
    
    UIView *view = [self selectedPhotoWheelViewCell];
    CGRect rect = [view bounds];
    
    UIPopoverController *popover = [[UIPopoverController alloc]
                                    initWithContentViewController:imagePicker];
    [popover presentPopoverFromRect:rect inView:view
           permittedArrowDirections:UIPopoverArrowDirectionAny animated:YES];
    [self setImagePickerPopoverController:popover];
}

- (void)presentCamera
{
    // Display the camera.
    UIImagePickerController *imagePicker = [self imagePickerController];
    [imagePicker setSourceType:UIImagePickerControllerSourceTypeCamera];
    [imagePicker setModalPresentationStyle:UIModalPresentationFullScreen];
    [self presentViewController:imagePicker animated:YES completion:nil];
}

- (void)presentPhotoPickerMenu
{
    UIActionSheet *actionSheet = [[UIActionSheet alloc] init];
    [actionSheet setDelegate:self];
    [actionSheet addButtonWithTitle:@"Take Photo"];
    [actionSheet addButtonWithTitle:@"Choose from Library"];
    
    UIView *view = [self selectedPhotoWheelViewCell];
    CGRect rect = [view bounds];
    [actionSheet showFromRect:rect inView:view animated:YES];
    
    [self setActionSheet:actionSheet];
}

#pragma mark - UIActionSheetDelegate methods

- (void)actionSheet:(UIActionSheet *)actionSheet
clickedButtonAtIndex:(NSInteger)buttonIndex
{
    switch (buttonIndex) {
        case 0:
            [self presentCamera];
            break;
        case 1:
            [self presentPhotoLibrary];
            break;
    }
}

- (void)actionSheet:(UIActionSheet *)actionSheet
didDismissWithButtonIndex:(NSInteger)buttonIndex
{
    [self setActionSheet:nil];
}

#pragma mark - UIImagePickerControllerDelegate methods

- (void)imagePickerController:(UIImagePickerController *)picker
didFinishPickingMediaWithInfo:(NSDictionary *)info
{
    // If the popover controller is available,
    // assume the photo is selected from the library
    // and not from the camera.
    BOOL takenWithCamera = ([self imagePickerPopoverController] == nil);
    
    // Dismiss the popover controller if available;
    // otherwise, dismiss the camera view.
    if ([self imagePickerPopoverController]) {
        [[self imagePickerPopoverController] dismissPopoverAnimated:YES];
        [self setImagePickerPopoverController:nil];
    } else {
        [self dismissViewControllerAnimated:YES completion:nil];
    }
    
    // Retrieve and display the image.
    UIImage *image = [info objectForKey:UIImagePickerControllerOriginalImage];
    [[self selectedPhotoWheelViewCell] setImage:image];
    
    if (takenWithCamera) {
        UIImageWriteToSavedPhotosAlbum(image, nil, nil, nil);
    }
}

@end
