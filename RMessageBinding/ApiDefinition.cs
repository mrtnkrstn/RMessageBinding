using System;
using Foundation;
using ObjCRuntime;
//using RMessage;
using UIKit;

namespace RMessageBinding
{
	// @protocol RMessageProtocol <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface RMessageProtocol
	{
		// @optional -(CGFloat)customVerticalOffsetForMessageView:(RMessageView *)messageView;
		[Export ("customVerticalOffsetForMessageView:")]
		nfloat CustomVerticalOffsetForMessageView (RMessageView messageView);

		// @optional -(void)customizeMessageView:(RMessageView *)messageView;
		[Export ("customizeMessageView:")]
		void CustomizeMessageView (RMessageView messageView);
	}

	// @interface RMessage : NSObject
	[BaseType (typeof (NSObject))]
	interface RMessage
	{
		[Wrap ("WeakDelegate")]
		RMessageProtocol Delegate { get; set; }

		// @property (assign, nonatomic) id<RMessageProtocol> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
		NSObject WeakDelegate { get; set; }

		// +(instancetype)sharedMessage;
		[Static]
		[Export ("sharedMessage")]
		RMessage SharedMessage ();

		// +(void)showNotificationWithTitle:(NSString *)message type:(RMessageType)type customTypeName:(NSString *)customTypeName callback:(void (^)())callback;
		[Static]
		[Export ("showNotificationWithTitle:type:customTypeName:callback:")]
		void ShowNotificationWithTitle (string message, RMessageType type, string customTypeName, Action callback);

		// +(void)showNotificationWithTitle:(NSString *)title subtitle:(NSString *)subtitle type:(RMessageType)type customTypeName:(NSString *)customTypeName callback:(void (^)())callback;
		[Static]
		[Export ("showNotificationWithTitle:subtitle:type:customTypeName:callback:")]
		void ShowNotificationWithTitle (string title, string subtitle, RMessageType type, string customTypeName, Action callback);

		// +(void)showNotificationWithTitle:(NSString *)title subtitle:(NSString *)subtitle type:(RMessageType)type customTypeName:(NSString *)customTypeName duration:(NSTimeInterval)duration callback:(void (^)())callback;
		[Static]
		[Export ("showNotificationWithTitle:subtitle:type:customTypeName:duration:callback:")]
		void ShowNotificationWithTitle (string title, string subtitle, RMessageType type, string customTypeName, double duration, Action callback);

		// +(void)showNotificationWithTitle:(NSString *)title subtitle:(NSString *)subtitle type:(RMessageType)type customTypeName:(NSString *)customTypeName duration:(NSTimeInterval)duration callback:(void (^)())callback canBeDismissedByUser:(BOOL)dismissingEnabled;
		[Static]
		[Export ("showNotificationWithTitle:subtitle:type:customTypeName:duration:callback:canBeDismissedByUser:")]
		void ShowNotificationWithTitle (string title, string subtitle, RMessageType type, string customTypeName, double duration, Action callback, bool dismissingEnabled);

		// +(void)showNotificationWithTitle:(NSString *)title subtitle:(NSString *)subtitle iconImage:(UIImage *)iconImage type:(RMessageType)type customTypeName:(NSString *)customTypeName duration:(NSTimeInterval)duration callback:(void (^)())callback buttonTitle:(NSString *)buttonTitle buttonCallback:(void (^)())buttonCallback atPosition:(RMessagePosition)messagePosition canBeDismissedByUser:(BOOL)dismissingEnabled;
		[Static]
		[Export ("showNotificationWithTitle:subtitle:iconImage:type:customTypeName:duration:callback:buttonTitle:buttonCallback:atPosition:canBeDismissedByUser:")]
		void ShowNotificationWithTitle (string title, string subtitle, UIImage iconImage, RMessageType type, string customTypeName, double duration, Action callback, string buttonTitle, Action buttonCallback, RMessagePosition messagePosition, bool dismissingEnabled);

		// +(void)showNotificationInViewController:(UIViewController *)viewController title:(NSString *)title subtitle:(NSString *)subtitle type:(RMessageType)type customTypeName:(NSString *)customTypeName callback:(void (^)())callback;
		[Static]
		[Export ("showNotificationInViewController:title:subtitle:type:customTypeName:callback:")]
		void ShowNotificationInViewController (UIViewController viewController, string title, string subtitle, RMessageType type, string customTypeName, Action callback);

		// +(void)showNotificationInViewController:(UIViewController *)viewController title:(NSString *)title subtitle:(NSString *)subtitle type:(RMessageType)type customTypeName:(NSString *)customTypeName duration:(NSTimeInterval)duration callback:(void (^)())callback;
		[Static]
		[Export ("showNotificationInViewController:title:subtitle:type:customTypeName:duration:callback:")]
		void ShowNotificationInViewController (UIViewController viewController, string title, string subtitle, RMessageType type, string customTypeName, double duration, Action callback);

		// +(void)showNotificationInViewController:(UIViewController *)viewController title:(NSString *)title subtitle:(NSString *)subtitle type:(RMessageType)type customTypeName:(NSString *)customTypeName duration:(NSTimeInterval)duration callback:(void (^)())callback canBeDismissedByUser:(BOOL)dismissingEnabled;
		[Static]
		[Export ("showNotificationInViewController:title:subtitle:type:customTypeName:duration:callback:canBeDismissedByUser:")]
		void ShowNotificationInViewController (UIViewController viewController, string title, string subtitle, RMessageType type, string customTypeName, double duration, Action callback, bool dismissingEnabled);

		// +(void)showNotificationInViewController:(UIViewController *)viewController title:(NSString *)title subtitle:(NSString *)subtitle iconImage:(UIImage *)iconImage type:(RMessageType)type customTypeName:(NSString *)customTypeName duration:(NSTimeInterval)duration callback:(void (^)())callback buttonTitle:(NSString *)buttonTitle buttonCallback:(void (^)())buttonCallback atPosition:(RMessagePosition)messagePosition canBeDismissedByUser:(BOOL)dismissingEnabled;
		[Static]
		[Export ("showNotificationInViewController:title:subtitle:iconImage:type:customTypeName:duration:callback:buttonTitle:buttonCallback:atPosition:canBeDismissedByUser:")]
		void ShowNotificationInViewController (UIViewController viewController, string title, string subtitle, UIImage iconImage, RMessageType type, string customTypeName, double duration, Action callback, string buttonTitle, Action buttonCallback, RMessagePosition messagePosition, bool dismissingEnabled);

		// +(BOOL)dismissActiveNotification;
		[Static]
		[Export ("dismissActiveNotification")]
		//[Verify (MethodToProperty)]
		bool DismissActiveNotification { get; }

		// +(BOOL)dismissActiveNotificationWithCompletion:(void (^)(void))completionBlock;
		[Static]
		[Export ("dismissActiveNotificationWithCompletion:")]
		bool DismissActiveNotificationWithCompletion (Action completionBlock);

		// +(void)setDefaultViewController:(UIViewController *)defaultViewController;
		[Static]
		[Export ("setDefaultViewController:")]
		void SetDefaultViewController (UIViewController defaultViewController);

		// +(void)setDelegate:(id<RMessageProtocol>)delegate;
		[Static]
		[Export ("setDelegate:")]
		void SetDelegate (RMessageProtocol @delegate);

		// +(void)addDesignsFromFileWithName:(NSString *)filename inBundle:(NSBundle *)bundle;
		[Static]
		[Export ("addDesignsFromFileWithName:inBundle:")]
		void AddDesignsFromFileWithName (string filename, NSBundle bundle);

		// +(BOOL)isNotificationActive;
		[Static]
		[Export ("isNotificationActive")]
		//[Verify (MethodToProperty)]
		bool IsNotificationActive { get; }

		// +(NSArray *)queuedMessages;
		[Static]
		[Export ("queuedMessages")]
		//[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] QueuedMessages { get; }

		// +(void)prepareNotificationForPresentation:(RMessageView *)messageView;
		[Static]
		[Export ("prepareNotificationForPresentation:")]
		void PrepareNotificationForPresentation (RMessageView messageView);
	}

	// @protocol RMessageViewProtocol <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface RMessageViewProtocol
	{
		// @required -(void)messageViewDidPresent:(RMessageView *)messageView;
		[Abstract]
		[Export ("messageViewDidPresent:")]
		void MessageViewDidPresent (RMessageView messageView);

		// @required -(void)messageViewDidDismiss:(RMessageView *)messageView;
		[Abstract]
		[Export ("messageViewDidDismiss:")]
		void MessageViewDidDismiss (RMessageView messageView);

		// @required -(CGFloat)customVerticalOffsetForMessageView:(RMessageView *)messageView;
		[Abstract]
		[Export ("customVerticalOffsetForMessageView:")]
		nfloat CustomVerticalOffsetForMessageView (RMessageView messageView);

		// @required -(void)windowRemovedForEndlessDurationMessageView:(RMessageView *)messageView;
		[Abstract]
		[Export ("windowRemovedForEndlessDurationMessageView:")]
		void WindowRemovedForEndlessDurationMessageView (RMessageView messageView);

		// @required -(void)didSwipeToDismissMessageView:(RMessageView *)messageView;
		[Abstract]
		[Export ("didSwipeToDismissMessageView:")]
		void DidSwipeToDismissMessageView (RMessageView messageView);

		// @required -(void)didTapMessageView:(RMessageView *)messageView;
		[Abstract]
		[Export ("didTapMessageView:")]
		void DidTapMessageView (RMessageView messageView);
	}

	// @interface RMessageView : UIView
	[BaseType (typeof (UIView))]
	interface RMessageView
	{
		[Wrap ("WeakDelegate")]
		RMessageViewProtocol Delegate { get; set; }

		// @property (nonatomic, weak) id<RMessageViewProtocol> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic) NSString * title;
		[Export ("title")]
		string Title { get; }

		// @property (readonly, nonatomic) NSString * subtitle;
		[Export ("subtitle")]
		string Subtitle { get; }

		// @property (readonly, nonatomic) UIViewController * viewController;
		[Export ("viewController")]
		UIViewController ViewController { get; }

		// @property (assign, nonatomic) CGFloat duration;
		[Export ("duration")]
		nfloat Duration { get; set; }

		// @property (assign, nonatomic) RMessagePosition messagePosition;
		[Export ("messagePosition", ArgumentSemantic.Assign)]
		RMessagePosition MessagePosition { get; set; }

		// @property (readonly, assign, nonatomic) RMessageType messageType;
		[Export ("messageType", ArgumentSemantic.Assign)]
		RMessageType MessageType { get; }

		// @property (readonly, copy, nonatomic) NSString * customTypeName;
		[Export ("customTypeName")]
		string CustomTypeName { get; }

		// @property (assign, nonatomic) CGFloat messageOpacity;
		[Export ("messageOpacity")]
		nfloat MessageOpacity { get; set; }

		// @property (assign, nonatomic) BOOL messageIsFullyDisplayed;
		[Export ("messageIsFullyDisplayed")]
		bool MessageIsFullyDisplayed { get; set; }

		// @property (nonatomic, strong) UIFont * titleFont __attribute__((annotate("ui_appearance_selector")));
		[Export ("titleFont", ArgumentSemantic.Strong)]
		UIFont TitleFont { get; set; }

		// @property (nonatomic, strong) UIColor * titleTextColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("titleTextColor", ArgumentSemantic.Strong)]
		UIColor TitleTextColor { get; set; }

		// @property (nonatomic, strong) UIFont * subtitleFont __attribute__((annotate("ui_appearance_selector")));
		[Export ("subtitleFont", ArgumentSemantic.Strong)]
		UIFont SubtitleFont { get; set; }

		// @property (nonatomic, strong) UIColor * subtitleTextColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("subtitleTextColor", ArgumentSemantic.Strong)]
		UIColor SubtitleTextColor { get; set; }

		// @property (nonatomic, strong) UIImage * messageIcon __attribute__((annotate("ui_appearance_selector")));
		[Export ("messageIcon", ArgumentSemantic.Strong)]
		UIImage MessageIcon { get; set; }

		// @property (nonatomic, strong) UIImage * errorIcon __attribute__((annotate("ui_appearance_selector")));
		[Export ("errorIcon", ArgumentSemantic.Strong)]
		UIImage ErrorIcon { get; set; }

		// @property (nonatomic, strong) UIImage * successIcon __attribute__((annotate("ui_appearance_selector")));
		[Export ("successIcon", ArgumentSemantic.Strong)]
		UIImage SuccessIcon { get; set; }

		// @property (nonatomic, strong) UIImage * warningIcon __attribute__((annotate("ui_appearance_selector")));
		[Export ("warningIcon", ArgumentSemantic.Strong)]
		UIImage WarningIcon { get; set; }

		// -(instancetype)initWithDelegate:(id<RMessageViewProtocol>)delegate title:(NSString *)title subtitle:(NSString *)subtitle iconImage:(UIImage *)iconImage type:(RMessageType)messageType customTypeName:(NSString *)customTypeName duration:(CGFloat)duration inViewController:(UIViewController *)viewController callback:(void (^)())callback buttonTitle:(NSString *)buttonTitle buttonCallback:(void (^)())buttonCallback atPosition:(RMessagePosition)position canBeDismissedByUser:(BOOL)dismissingEnabled;
		[Export ("initWithDelegate:title:subtitle:iconImage:type:customTypeName:duration:inViewController:callback:buttonTitle:buttonCallback:atPosition:canBeDismissedByUser:")]
		IntPtr Constructor (RMessageViewProtocol @delegate, string title, string subtitle, UIImage iconImage, RMessageType messageType, string customTypeName, nfloat duration, UIViewController viewController, Action callback, string buttonTitle, Action buttonCallback, RMessagePosition position, bool dismissingEnabled);

		// +(void)addDesignsFromFileWithName:(NSString *)filename inBundle:(NSBundle *)bundle;
		[Static]
		[Export ("addDesignsFromFileWithName:inBundle:")]
		void AddDesignsFromFileWithName (string filename, NSBundle bundle);

		// -(void)executeMessageViewCallBack;
		[Export ("executeMessageViewCallBack")]
		void ExecuteMessageViewCallBack ();

		// -(void)executeMessageViewButtonCallBack;
		[Export ("executeMessageViewButtonCallBack")]
		void ExecuteMessageViewButtonCallBack ();

		// -(void)present;
		[Export ("present")]
		void Present ();

		// -(void)dismissWithCompletion:(void (^)(void))completionBlock;
		[Export ("dismissWithCompletion:")]
		void DismissWithCompletion (Action completionBlock);
	}

	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double RMessageVersionNumber;
		[Field ("RMessageVersionNumber", "__Internal")]
		double RMessageVersionNumber { get; }

		// extern const unsigned char [] RMessageVersionString;
		[Field ("RMessageVersionString", "__Internal")]
		byte[] RMessageVersionString { get; }
	}
}
