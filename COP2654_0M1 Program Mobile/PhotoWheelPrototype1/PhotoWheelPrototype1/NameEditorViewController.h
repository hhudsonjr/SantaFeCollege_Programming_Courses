//
//  NameEditorViewController.h
//  PhotoWheelPrototype1
//
//  Created by HansulHudson on 10/28/13.
//  Copyright (c) 2013 HansulHudson. All rights reserved.
//

#import <UIKit/UIKit.h>

@protocol NameEditorViewControllerDelegate;

@interface NameEditorViewController : UIViewController

@property (nonatomic, weak) IBOutlet UITextField *nameTextField;
@property (nonatomic, weak) id<NameEditorViewControllerDelegate> delegate;

- (IBAction)cancel:(id)sender;
- (IBAction)done:(id)sender;

- (id)initWithDefaultNib;

@property (nonatomic, strong) NSIndexPath *indexPath;
@property (nonatomic, copy) NSString *defaultNameText;

@end



@protocol NameEditorViewControllerDelegate <NSObject>

@optional
- (void)nameEditorViewControllerDidFinish: (NameEditorViewController *)controller;
-(void)nameEditorViewControllerDidCancel:(NameEditorViewController *)controller;

@end