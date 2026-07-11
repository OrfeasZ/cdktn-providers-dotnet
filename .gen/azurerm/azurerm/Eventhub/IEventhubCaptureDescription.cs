using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Eventhub
{
    [JsiiInterface(nativeType: typeof(IEventhubCaptureDescription), fullyQualifiedName: "azurerm.eventhub.EventhubCaptureDescription")]
    public interface IEventhubCaptureDescription
    {
        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/eventhub#destination Eventhub#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"azurerm.eventhub.EventhubCaptureDescriptionDestination\"}")]
        azurerm.Eventhub.IEventhubCaptureDescriptionDestination Destination
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/eventhub#enabled Eventhub#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/eventhub#encoding Eventhub#encoding}.</summary>
        [JsiiProperty(name: "encoding", typeJson: "{\"primitive\":\"string\"}")]
        string Encoding
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/eventhub#interval_in_seconds Eventhub#interval_in_seconds}.</summary>
        [JsiiProperty(name: "intervalInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IntervalInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/eventhub#size_limit_in_bytes Eventhub#size_limit_in_bytes}.</summary>
        [JsiiProperty(name: "sizeLimitInBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SizeLimitInBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/eventhub#skip_empty_archives Eventhub#skip_empty_archives}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "skipEmptyArchives", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipEmptyArchives
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEventhubCaptureDescription), fullyQualifiedName: "azurerm.eventhub.EventhubCaptureDescription")]
        internal sealed class _Proxy : DeputyBase, azurerm.Eventhub.IEventhubCaptureDescription
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/eventhub#destination Eventhub#destination}
            /// </remarks>
            [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"azurerm.eventhub.EventhubCaptureDescriptionDestination\"}")]
            public azurerm.Eventhub.IEventhubCaptureDescriptionDestination Destination
            {
                get => GetInstanceProperty<azurerm.Eventhub.IEventhubCaptureDescriptionDestination>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/eventhub#enabled Eventhub#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/eventhub#encoding Eventhub#encoding}.</summary>
            [JsiiProperty(name: "encoding", typeJson: "{\"primitive\":\"string\"}")]
            public string Encoding
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/eventhub#interval_in_seconds Eventhub#interval_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "intervalInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IntervalInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/eventhub#size_limit_in_bytes Eventhub#size_limit_in_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sizeLimitInBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SizeLimitInBytes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/eventhub#skip_empty_archives Eventhub#skip_empty_archives}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skipEmptyArchives", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SkipEmptyArchives
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
