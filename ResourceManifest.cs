using Orchard.UI.Resources;

namespace Diaco.KimiaRazi
{
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            manifest.DefineStyle("Animate").SetUrl("animate.min.css", "animate.css")
                .SetCdn("//cdnjs.cloudflare.com/ajax/libs/animate.css/3.5.2/animate.min.css", "//cdnjs.cloudflare.com/ajax/libs/animate.css/3.5.2/animate.css", true)
                .SetVersion("3.5.2");

            manifest.DefineStyle("Toastr").SetUrl("toastr.min.css", "toastr.css")
                .SetCdn("//cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.css", "//cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.css", true);
            manifest.DefineScript("Toastr").SetUrl("toastr.min.js", "toastr.js")
                .SetCdn("//cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.js")
                .SetDependencies("jQuery");

            manifest.DefineScript("jQueryEasing").SetUrl("jquery.easing.min.js", "jquery.easing.js")
                .SetCdn("//cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.4.1/jquery.easing.min.js", "//cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.4.1/jquery.easing.js", true)
                .SetVersion("1.4.1")
                .SetDependencies("jQuery");

            manifest.DefineScript("jQueryViewportChecker").SetUrl("jquery.viewportchecker.min.js")
                .SetCdn("//cdnjs.cloudflare.com/ajax/libs/jQuery-viewport-checker/1.8.8/jquery.viewportchecker.min.js")
                .SetVersion("1.8.8")
                .SetDependencies("jQuery");

            manifest.DefineScript("Classie").SetUrl("classie.min.js", "classie.js")
                .SetCdn("//cdnjs.cloudflare.com/ajax/libs/classie/1.0.1/classie.min.js", "//cdnjs.cloudflare.com/ajax/libs/classie/1.0.1/classie.js", true)
                .SetVersion("1.0.1");

            manifest.DefineStyle("Font_Montserrat").SetCdn("//fonts.googleapis.com/css?family=Montserrat:400,700");
            manifest.DefineStyle("Font_Lora").SetCdn("//fonts.googleapis.com/css?family=Lora:400,700,400italic,700italic");
        }
    }
}
