//
//  DetailViewController.h
//  PhotoWheelPrototype1
//
//  Created by HansulHudson on 10/28/13.
//  Copyright (c) 2013 HansulHudson. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "WheelView.h"


@interface DetailViewController : UIViewController <UISplitViewControllerDelegate, UICollectionViewDataSource, UICollectionViewDelegate, WheelViewDataSource, UIActionSheetDelegate, UINavigationControllerDelegate, UIImagePickerControllerDelegate>

@property (weak, nonatomic) IBOutlet UICollectionView *collectionView;

@property (strong, nonatomic) id detailItem;

@property (weak, nonatomic) IBOutlet UILabel *detailDescriptionLabel;
@property (weak, nonatomic) IBOutlet WheelView *wheelView;
@end
