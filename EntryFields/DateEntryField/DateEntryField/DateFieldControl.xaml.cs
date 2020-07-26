using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DateEntryField
{
    public partial class DateFieldControl : ContentView
    {
        #region Appearance
        private Color InnerColor
        {
            get => (Color)GetValue(InnerColorProperty);
            set => SetValue(InnerColorProperty, value);
        }

        public static BindableProperty InnerColorProperty = BindableProperty.Create(
            propertyName: nameof(InnerColor),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(Color),
            defaultBindingMode: BindingMode.TwoWay);

        private Color BorderColor
        {
            get => (Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }

        public static BindableProperty BorderColorProperty = BindableProperty.Create(
            propertyName: nameof(BorderColor),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(Color),
            defaultBindingMode: BindingMode.TwoWay);

        private Color UnderlineColor
        {
            get => (Color)GetValue(UnderlineColorProperty);
            set => SetValue(UnderlineColorProperty, value);
        }

        public static BindableProperty UnderlineColorProperty = BindableProperty.Create(
            propertyName: nameof(UnderlineColor),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(Color),
            defaultBindingMode: BindingMode.TwoWay);

        private Color HeadingColor
        {
            get => (Color)GetValue(HeadingColorProperty);
            set => SetValue(HeadingColorProperty, value);
        }

        public static BindableProperty HeadingColorProperty = BindableProperty.Create(
            propertyName: nameof(HeadingColor),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(Color),
            defaultBindingMode: BindingMode.TwoWay);

        private Color PlaceHolderColor
        {
            get => (Color)GetValue(PlaceHolderColorProperty);
            set => SetValue(PlaceHolderColorProperty, value);
        }

        public static BindableProperty PlaceHolderColorProperty = BindableProperty.Create(
            propertyName: nameof(PlaceHolderColor),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(Color),
            defaultBindingMode: BindingMode.TwoWay);

        private Color TextColor
        {
            get => (Color)GetValue(TextColorProperty);
            set => SetValue(TextColorProperty, value);
        }

        public static BindableProperty TextColorProperty = BindableProperty.Create(
            propertyName: nameof(TextColor),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(Color),
            defaultBindingMode: BindingMode.TwoWay);
        #endregion

        #region Control State
        public DateTime MinDate
        {
            get => (DateTime)GetValue(MinDateProperty);
            set => SetValue(MinDateProperty, value);
        }

        public static BindableProperty MinDateProperty = BindableProperty.Create(
            propertyName: nameof(MinDate),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(DateTime),
            defaultBindingMode: BindingMode.TwoWay);

        public DateTime MaxDate
        {
            get => (DateTime)GetValue(MaxDateProperty);
            set => SetValue(MaxDateProperty, value);
        }

        public static BindableProperty MaxDateProperty = BindableProperty.Create(
            propertyName: nameof(MaxDate),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(DateTime),
            defaultBindingMode: BindingMode.TwoWay);

        public DateTime Date
        {
            get => (DateTime)GetValue(DateProperty);
            set => SetValue(DateProperty, value);
        }

        public static BindableProperty DateProperty = BindableProperty.Create(
            propertyName: nameof(Date),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(DateTime),
            defaultBindingMode: BindingMode.TwoWay);

        public string Entry
        {
            get => (string)GetValue(EntryProperty);
            set => SetValue(EntryProperty, value);
        }

        public static BindableProperty EntryProperty = BindableProperty.Create(
            propertyName: nameof(EntryProperty),
            declaringType: typeof(DateFieldControl),
            returnType: typeof(string),
            defaultBindingMode: BindingMode.TwoWay);

        public bool DateSelected
        {
            get => (bool)GetValue(DateSelectedProperty);
            set => SetValue(DateSelectedProperty, value);
        }

        public static BindableProperty DateSelectedProperty = BindableProperty.Create(
           propertyName: nameof(DateSelected),
           declaringType: typeof(DateFieldControl),
           returnType: typeof(bool),
           defaultBindingMode: BindingMode.TwoWay);

        public bool ClearingEnabled
        {
            get => (bool)GetValue(ClearingEnabledProperty);
            set => SetValue(ClearingEnabledProperty, value);
        }

        public static BindableProperty ClearingEnabledProperty = BindableProperty.Create(
           propertyName: nameof(ClearingEnabled),
           declaringType: typeof(DateFieldControl),
           returnType: typeof(bool),
           defaultBindingMode: BindingMode.TwoWay);

        public bool UnderlineEnabled
        {
            get => (bool)GetValue(UnderlinEnabledProeprty);
            set => SetValue(UnderlinEnabledProeprty, value);
        }

        public static BindableProperty UnderlinEnabledProeprty = BindableProperty.Create(
           propertyName: nameof(UnderlineEnabled),
           declaringType: typeof(DateFieldControl),
           returnType: typeof(bool),
           defaultBindingMode: BindingMode.TwoWay);
        #endregion

        public DateFieldControl()
        {
            InitializeComponent();
        }
    }
}
