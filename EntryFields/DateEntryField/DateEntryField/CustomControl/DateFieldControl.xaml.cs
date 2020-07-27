using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CustomControl
{
    public partial class DateFieldControl : ContentView
    {
        #region Appearance
        #region Border
        private Color BorderColor
        {
            get => (Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }

        private float BorderRadius
        {
            get => (float)GetValue(BorderRadiusproperty);
            set => SetValue(BorderRadiusproperty, value);
        }

        private Thickness BorderThickness
        {
            get => (Thickness)GetValue(BorderThicknessProperty);
            set => SetValue(BorderThicknessProperty, value);
        }

        public static BindableProperty BorderColorProperty = BindableProperty.Create(
            propertyName: nameof(BorderColor),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(Color),
            defaultBindingMode: BindingMode.TwoWay,
            defaultValue: Color.FromHex("#C7C3C3"));

        public static BindableProperty BorderRadiusproperty = BindableProperty.Create(
            propertyName: nameof(BorderRadius),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(float),
            defaultBindingMode: BindingMode.TwoWay,
            defaultValue: 6.0);

        public static BindableProperty BorderThicknessProperty = BindableProperty.Create(
            propertyName: nameof(BorderThickness),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(Thickness),
            defaultBindingMode: BindingMode.TwoWay,
            defaultValue: 1.0);

        #endregion

        #region Background
        private Color InnerColor
        {
            get => (Color)GetValue(InnerColorProperty);
            set => SetValue(InnerColorProperty, value);
        }

        public static BindableProperty InnerColorProperty = BindableProperty.Create(
            propertyName: nameof(InnerColor),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(Color),
            defaultBindingMode: BindingMode.TwoWay,
            defaultValue: Color.FromHex("#FFFFFF"));
        #endregion

        #region Underline
        private Color UnderlineColor
        {
            get => (Color)GetValue(UnderlineColorProperty);
            set => SetValue(UnderlineColorProperty, value);
        }

        public static BindableProperty UnderlineColorProperty = BindableProperty.Create(
            propertyName: nameof(UnderlineColor),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(Color),
            defaultBindingMode: BindingMode.TwoWay,
            defaultValue: Color.FromHex("#202020"));
        #endregion

        #region Text
        private Color HeadingColor
        {
            get => (Color)GetValue(HeadingColorProperty);
            set => SetValue(HeadingColorProperty, value);
        }

        private Color TextColor
        {
            get => (Color)GetValue(TextColorProperty);
            set => SetValue(TextColorProperty, value);
        }

        private Color PlaceHolderColor
        {
            get => (Color)GetValue(PlaceHolderColorProperty);
            set => SetValue(PlaceHolderColorProperty, value);
        }

        public static BindableProperty HeadingColorProperty = BindableProperty.Create(
            propertyName: nameof(HeadingColor),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(Color),
            defaultBindingMode: BindingMode.TwoWay,
            defaultValue: Color.FromHex("#202020"));

        public static BindableProperty TextColorProperty = BindableProperty.Create(
            propertyName: nameof(TextColor),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(Color),
            defaultBindingMode: BindingMode.TwoWay,
            defaultValue: Color.FromHex("#202020"));

        public static BindableProperty PlaceHolderColorProperty = BindableProperty.Create(
            propertyName: nameof(PlaceHolderColor),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(Color),
            defaultBindingMode: BindingMode.TwoWay,
            defaultValue: Color.FromHex("#979797"));
        #endregion
        #endregion

        #region Control State
        public DateTime MinDate
        {
            get => (DateTime)GetValue(MinDateProperty);
            set => SetValue(MinDateProperty, value);
        }

        public DateTime MaxDate
        {
            get => (DateTime)GetValue(MaxDateProperty);
            set => SetValue(MaxDateProperty, value);
        }

        public DateTime Date
        {
            get => (DateTime)GetValue(DateProperty);
            set => SetValue(DateProperty, value);
        }

        public string Heading
        {
            get => (string)GetValue(HeadingProperty);
            set => SetValue(HeadingProperty, value);
        }

        public string Entry
        {
            get => (string)GetValue(EntryProperty);
            set => SetValue(EntryProperty, value);
        }

        public string PlaceHolder
        {
            get => (string)GetValue(PlaceHolderProperty);
            set => SetValue(PlaceHolderProperty, value);
        }

        public bool DateWasSelected
        {
            get => (bool)GetValue(DateWasSelectedProperty);
            set => SetValue(DateWasSelectedProperty, value);
        }

        public bool ClearingEnabled
        {
            get => (bool)GetValue(ClearingEnabledProperty);
            set => SetValue(ClearingEnabledProperty, value);
        }

        public bool UnderlineEnabled
        {
            get => (bool)GetValue(UnderlinEnabledProeprty);
            set => SetValue(UnderlinEnabledProeprty, value);
        }

        public static BindableProperty MinDateProperty = BindableProperty.Create(
            propertyName: nameof(MinDate),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(DateTime),
            defaultBindingMode: BindingMode.TwoWay,
            defaultValue: DateTime.Now.Date.AddYears(-100));

        public static BindableProperty MaxDateProperty = BindableProperty.Create(
            propertyName: nameof(MaxDate),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(DateTime),
            defaultBindingMode: BindingMode.TwoWay,
            defaultValue: DateTime.Now.Date);

        public static BindableProperty DateProperty = BindableProperty.Create(
            propertyName: nameof(Date),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(DateTime),
            defaultBindingMode: BindingMode.TwoWay);

        public static BindableProperty HeadingProperty = BindableProperty.Create(
           propertyName: nameof(Heading),
           declaringType: typeof(DateFieldControl),
           returnType: typeof(string),
           defaultBindingMode: BindingMode.TwoWay,
           defaultValue: "Heading");

        public static BindableProperty EntryProperty = BindableProperty.Create(
            propertyName: nameof(EntryProperty),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(string),
            defaultBindingMode: BindingMode.TwoWay);

        public static BindableProperty PlaceHolderProperty = BindableProperty.Create(
            propertyName: nameof(PlaceHolder),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(string),
            defaultBindingMode: BindingMode.TwoWay,
            defaultValue: "Place Holder");

        public static BindableProperty DateWasSelectedProperty = BindableProperty.Create(
           propertyName: nameof(DateWasSelected),
           declaringType: typeof(DateFieldControl),
           returnType: typeof(bool),
           defaultBindingMode: BindingMode.TwoWay,
           defaultValue: false);

        public static BindableProperty ClearingEnabledProperty = BindableProperty.Create(
           propertyName: nameof(ClearingEnabled),
           declaringType: typeof(DateFieldControl),
           returnType: typeof(bool),
           defaultBindingMode: BindingMode.TwoWay,
           defaultValue: true);

        public static BindableProperty UnderlinEnabledProeprty = BindableProperty.Create(
           propertyName: nameof(UnderlineEnabled),
           declaringType: typeof(DateFieldControl),
           returnType: typeof(bool),
           defaultBindingMode: BindingMode.TwoWay,
           defaultValue: true);
        #endregion

        public DateFieldControl()
        {
            InitializeComponent();
        }
    }
}
