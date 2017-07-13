//
//  ViewController.h
//  Project 2
//
//  Created by Hansul Hudson Jr on 9/9/13.
//  Copyright (c) 2013 Hansul Hudson Jr. All rights reserved.
//

#import <UIKit/UIKit.h>

@interface ViewController : UIViewController

@property (nonatomic, weak) IBOutlet UILabel *favoriteFLabel;
@property (nonatomic, weak) IBOutlet UITextField *foodField;

- (IBAction)displayFavoriteFood:(id)sender;

@property (nonatomic, weak) IBOutlet UILabel *favoriteMLabel;
@property (nonatomic, weak) IBOutlet UITextField *movieField;

- (IBAction)displayFavoriteMovie:(id)sender;

@property (nonatomic, weak) IBOutlet UILabel *favoriteCLabel;
@property (nonatomic, weak) IBOutlet UITextField *colorField;

- (IBAction)displayFavoriteColor:(id)sender;

@end
