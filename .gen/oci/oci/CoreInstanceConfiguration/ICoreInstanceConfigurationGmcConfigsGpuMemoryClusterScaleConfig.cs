using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    [JsiiInterface(nativeType: typeof(ICoreInstanceConfigurationGmcConfigsGpuMemoryClusterScaleConfig), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationGmcConfigsGpuMemoryClusterScaleConfig")]
    public interface ICoreInstanceConfigurationGmcConfigsGpuMemoryClusterScaleConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/core_instance_configuration#is_upsize_enabled CoreInstanceConfiguration#is_upsize_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isUpsizeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsUpsizeEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/core_instance_configuration#is_downsize_enabled CoreInstanceConfiguration#is_downsize_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isDownsizeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsDownsizeEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/core_instance_configuration#target_size CoreInstanceConfiguration#target_size}.</summary>
        [JsiiProperty(name: "targetSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetSize
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstanceConfigurationGmcConfigsGpuMemoryClusterScaleConfig), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationGmcConfigsGpuMemoryClusterScaleConfig")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstanceConfiguration.ICoreInstanceConfigurationGmcConfigsGpuMemoryClusterScaleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/core_instance_configuration#is_upsize_enabled CoreInstanceConfiguration#is_upsize_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "isUpsizeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsUpsizeEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/core_instance_configuration#is_downsize_enabled CoreInstanceConfiguration#is_downsize_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isDownsizeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsDownsizeEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/core_instance_configuration#target_size CoreInstanceConfiguration#target_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetSize
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
