//
//  WheelView.h
//  PhotoWheelPrototype1
//
//  Created by Digital Media Technology on 11/5/13.
//  Copyright (c) 2013 HansulHudson. All rights reserved.
//

#import <UIKit/UIKit.h>

@protocol WheelViewDataSource;
@class WheelViewCell;

typedef enum  {
    WheelViewStyleWheel,
    WheelViewStyleCarousel,
} WheelViewStyle;

@interface WheelView : UIView

@property (nonatomic, weak) IBOutlet id<WheelViewDataSource> dataSource;
@property (nonatomic, assign) WheelViewStyle style;

@end


@protocol WheelViewDataSource <NSObject>
@required
- (NSInteger)wheelViewNumberOfCells:(WheelView *)wheelView;
- (WheelViewCell *)wheelView:(WheelView *)wheelView cellAtIndex:(NSInteger)index;
@end


@interface WheelViewCell : UIView
@end