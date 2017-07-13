//
//  SpinGestureRecognizer.h
//  PhotoWheelPrototype1
//
//  Created by Digital Media Technology on 11/5/13.
//  Copyright (c) 2013 HansulHudson. All rights reserved.
//

#import <UIKit/UIKit.h>

@interface SpinGestureRecognizer : UIGestureRecognizer

/**
 The rotation of the gesture in radians since its last change.
 */
@property (nonatomic, assign) CGFloat rotation;

@end
