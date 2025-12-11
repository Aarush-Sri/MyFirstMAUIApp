namespace MyFirstMAUIApp
{ 
    using View;
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {

            Routing.RegisterRoute(nameof(LayoutsPage), typeof(LayoutsPage));
            Routing.RegisterRoute(nameof(StackLayoutPage), typeof(StackLayoutPage));
            Routing.RegisterRoute(nameof(LayoutVerticalStackPage), typeof(LayoutVerticalStackPage));
            Routing.RegisterRoute(nameof(LayoutHorizontalStackPage), typeof(LayoutHorizontalStackPage));
            Routing.RegisterRoute(nameof(LayoutsAbsolutePage), typeof(LayoutsAbsolutePage));
            Routing.RegisterRoute(nameof(LayoutFlexPage), typeof(LayoutFlexPage));



            Routing.RegisterRoute(nameof(ImagesPage), typeof(ImagesPage));
            Routing.RegisterRoute(nameof(ImagesURIPage), typeof(ImagesURIPage));
            Routing.RegisterRoute(nameof(EmbeddedImagePage), typeof(EmbeddedImagePage));
            Routing.RegisterRoute(nameof(ActivityLoaderPage), typeof(ActivityLoaderPage));


            Routing.RegisterRoute(nameof(CollectionsPage), typeof(CollectionsPage));

            Routing.RegisterRoute(nameof(CollectionPage), typeof(CollectionPage));


            Routing.RegisterRoute(nameof(CollectionImagesPage), typeof(CollectionImagesPage));








        }
    }
}
