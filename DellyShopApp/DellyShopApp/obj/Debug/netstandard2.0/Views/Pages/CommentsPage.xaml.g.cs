//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("DellyShopApp.Views.Pages.CommentsPage.xaml", "Views/Pages/CommentsPage.xaml", typeof(global::DellyShopApp.Views.Pages.CommentsPage))]

namespace DellyShopApp.Views.Pages {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views/Pages/CommentsPage.xaml")]
    public partial class CommentsPage : global::DellyShopApp.Views.Pages.Base.BasePage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label Title;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::DellyShopApp.CustomControl.RepeaterView CommentList;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::DellyShopApp.Views.CustomView.PancakeView FilterLayout;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::DellyShopApp.CustomControl.RepeaterView filterStars;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(CommentsPage));
            Title = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "Title");
            CommentList = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::DellyShopApp.CustomControl.RepeaterView>(this, "CommentList");
            FilterLayout = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::DellyShopApp.Views.CustomView.PancakeView>(this, "FilterLayout");
            filterStars = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::DellyShopApp.CustomControl.RepeaterView>(this, "filterStars");
        }
    }
}