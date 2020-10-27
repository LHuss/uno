using Windows.Foundation;

namespace Windows.UI.Xaml.Controls.Primitives
{
    public partial class CommandBarTemplateSettings : DependencyObject
	{
		private readonly CommandBar _commandBar;

		public CommandBarTemplateSettings(CommandBar commandBar)
		{
			_commandBar = commandBar;
		}

		public double ContentHeight
		{
			get => (double)GetValue(ContentHeightProperty);
			internal set => SetValue(ContentHeightProperty, value);
		}

		public static DependencyProperty ContentHeightProperty { get; } =
			DependencyProperty.Register(
				"ContentHeight",
				typeof(double),
				typeof(CommandBarTemplateSettings),
				new FrameworkPropertyMetadata(
					defaultValue: 0,
					options: FrameworkPropertyMetadataOptions.Inherits
				)
			);

		public double NegativeOverflowContentHeight { get; internal set; }

		public static DependencyProperty NegativeOverflowContentHeightProperty { get; } =
			DependencyProperty.Register(
				"NegativeOverflowContentHeight",
				typeof(double),
				typeof(CommandBarTemplateSettings),
				new FrameworkPropertyMetadata(
					defaultValue: 0,
					options: FrameworkPropertyMetadataOptions.Inherits
				)
			);

		public Rect OverflowContentClipRect
		{
			get => (Rect)GetValue(OverflowContentClipRectProperty);
			internal set => SetValue(OverflowContentClipRectProperty, value);
		}

		public static DependencyProperty OverflowContentClipRectProperty { get; } =
			DependencyProperty.Register(
				"OverflowContentClipRect",
				typeof(Rect),
				typeof(CommandBarTemplateSettings),
				new FrameworkPropertyMetadata(
					defaultValue: new Rect(0, 0, double.PositiveInfinity, double.PositiveInfinity),
					options: FrameworkPropertyMetadataOptions.Inherits
				)
			);

		public double OverflowContentHeight { get; internal set; }

		public static DependencyProperty OverflowContentHeightProperty { get; } =
			DependencyProperty.Register(
				"OverflowContentHeight",
				typeof(double),
				typeof(CommandBarTemplateSettings),
				new FrameworkPropertyMetadata(
					defaultValue: 0,
					options: FrameworkPropertyMetadataOptions.Inherits
				)
			);

		public double OverflowContentHorizontalOffset { get; internal set; }

		public static DependencyProperty OverflowContentHorizontalOffsetProperty { get; } =
			DependencyProperty.Register(
				"OverflowContentHorizontalOffset",
				typeof(double),
				typeof(CommandBarTemplateSettings),
				new FrameworkPropertyMetadata(
					defaultValue: 0,
					options: FrameworkPropertyMetadataOptions.Inherits
				)
			);

		public double OverflowContentMaxHeight
		{
			get => (double)GetValue(OverflowContentMaxHeightProperty);
			internal set => SetValue(OverflowContentMaxHeightProperty, value);
		}

		public static DependencyProperty OverflowContentMaxHeightProperty { get; } =
			DependencyProperty.Register(
				"OverflowContentMaxHeight",
				typeof(double),
				typeof(CommandBarTemplateSettings),
				new FrameworkPropertyMetadata(
					defaultValue: double.PositiveInfinity,
					options: FrameworkPropertyMetadataOptions.Inherits
				)
			);

		public double OverflowContentMinWidth { get; internal set; }

		public static DependencyProperty OverflowContentMinWidthProperty { get; } =
			DependencyProperty.Register(
				"OverflowContentMinWidth",
				typeof(double),
				typeof(CommandBarTemplateSettings),
				new FrameworkPropertyMetadata(
					defaultValue: double.NegativeInfinity,
					options: FrameworkPropertyMetadataOptions.Inherits
				)
			);


		public double OverflowContentMaxWidth
		{
			get => (double)GetValue(OverflowContentMaxWidthProperty);
			internal set => SetValue(OverflowContentMaxWidthProperty, value);
		}

		public static DependencyProperty OverflowContentMaxWidthProperty { get; } =
			DependencyProperty.Register(
				"OverflowContentMaxWidth",
				typeof(double),
				typeof(CommandBarTemplateSettings),
				new FrameworkPropertyMetadata(
					defaultValue: double.PositiveInfinity,
					options: FrameworkPropertyMetadataOptions.Inherits
				)
			);

		public Visibility EffectiveOverflowButtonVisibility { get; internal set; }

		public static DependencyProperty EffectiveOverflowButtonVisibilityProperty { get; } =
			DependencyProperty.Register(
				"EffectiveOverflowButtonVisibility",
				typeof(Visibility),
				typeof(CommandBarTemplateSettings),
				new FrameworkPropertyMetadata(
					defaultValue: Visibility.Visible,
					options: FrameworkPropertyMetadataOptions.Inherits
				)
			);
	}
}
