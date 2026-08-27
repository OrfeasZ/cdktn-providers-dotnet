using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.windowsWebApp.WindowsWebAppSiteConfigVirtualApplication")]
    public class WindowsWebAppSiteConfigVirtualApplication : azurerm.WindowsWebApp.IWindowsWebAppSiteConfigVirtualApplication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_web_app#physical_path WindowsWebApp#physical_path}.</summary>
        [JsiiProperty(name: "physicalPath", typeJson: "{\"primitive\":\"string\"}")]
        public string PhysicalPath
        {
            get;
            set;
        }

        private object _preload;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_web_app#preload WindowsWebApp#preload}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "preload", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object Preload
        {
            get => _preload;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _preload = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_web_app#virtual_path WindowsWebApp#virtual_path}.</summary>
        [JsiiProperty(name: "virtualPath", typeJson: "{\"primitive\":\"string\"}")]
        public string VirtualPath
        {
            get;
            set;
        }

        private object? _virtualDirectory;

        /// <summary>virtual_directory block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_web_app#virtual_directory WindowsWebApp#virtual_directory}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.WindowsWebApp.IWindowsWebAppSiteConfigVirtualApplicationVirtualDirectory" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualDirectory", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigVirtualApplicationVirtualDirectory\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VirtualDirectory
        {
            get => _virtualDirectory;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.WindowsWebApp.IWindowsWebAppSiteConfigVirtualApplicationVirtualDirectory[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.WindowsWebApp.IWindowsWebAppSiteConfigVirtualApplicationVirtualDirectory).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _virtualDirectory = value;
            }
        }
    }
}
