//
//  ViewController.m
//  Project 2
//
//  Created by Hansul Hudson Jr on 9/9/13.
//  Copyright (c) 2013 Hansul Hudson Jr. All rights reserved.
//

#import "ViewController.h"



@implementation ViewController

@synthesize favoriteFLabel;
@synthesize foodField;

- (IBAction)displayFavoriteFood:(id)sender
{
    NSString *favoriteF = [NSString stringWithFormat:@"Your favorite food is %@", [foodField text]];
    [favoriteFLabel setText:favoriteF];
}

@synthesize favoriteMLabel;
@synthesize movieField;

- (IBAction)displayFavoriteMovie:(id)sender
{
    NSString *favoriteM = [NSString stringWithFormat:@"Your favorite movie is %@", [movieField text]];
    [favoriteMLabel setText:favoriteM];
}

@synthesize favoriteCLabel;
@synthesize colorField;

- (IBAction)displayFavoriteColor:(id)sender
{
    NSString *favoriteC = [NSString stringWithFormat:@"Your favorite color is %@", [colorField text]];
    [favoriteCLabel setText:favoriteC];
}



@end
