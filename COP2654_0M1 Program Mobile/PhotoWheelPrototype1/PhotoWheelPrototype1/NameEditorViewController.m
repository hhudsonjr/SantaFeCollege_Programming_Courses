//
//  NameEditorViewController.m
//  PhotoWheelPrototype1
//
//  Created by HansulHudson on 10/28/13.
//  Copyright (c) 2013 HansulHudson. All rights reserved.
//

#import "NameEditorViewController.h"

@interface NameEditorViewController ()

@end

@implementation NameEditorViewController

- (id)initWithDefaultNib
{
    self = [super initWithNibName:@"NameEditorViewController" bundle:nil];
    if (self) {
        // Customize initialization
    }
    return self;
}

- (id)initWithNibName:(NSString *)nibNameOrNil bundle:(NSBundle *)nibBundleOrNil
{
    self = [super initWithNibName:nibNameOrNil bundle:nibBundleOrNil];
    if (self) {
        // Custom initialization
    }
    return self;
}

- (void)viewDidLoad
{
    [super viewDidLoad];
    if ([self isEditing]) {
        [[self nameTextField] setText:[self defaultNameText]];
    }
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

#pragma mark - Actions methods

- (IBAction)cancel:(id)sender;
{
    id<NameEditorViewControllerDelegate> delegate = [self delegate];
    if (delegate &&[delegate respondsToSelector:@selector(nameEditorViewControllerDidCancel:)]) {
        [delegate nameEditorViewControllerDidCancel:self];
    }
    [self dismissViewControllerAnimated:YES completion:nil];
}

- (IBAction)done:(id)sender;
{
    id<NameEditorViewControllerDelegate> delegate = [self delegate];
    if (delegate &&[delegate respondsToSelector:@selector(nameEditorViewControllerDidCancel:)]) {
        [delegate nameEditorViewControllerDidFinish:self];
    }
    [self dismissViewControllerAnimated:YES completion:nil];
}

@end
