using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApiaccesscontrolApiMetadatas
{
    [JsiiInterface(nativeType: typeof(IDataOciApiaccesscontrolApiMetadatasFilter), fullyQualifiedName: "oci.dataOciApiaccesscontrolApiMetadatas.DataOciApiaccesscontrolApiMetadatasFilter")]
    public interface IDataOciApiaccesscontrolApiMetadatasFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/data-sources/apiaccesscontrol_api_metadatas#name DataOciApiaccesscontrolApiMetadatas#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/data-sources/apiaccesscontrol_api_metadatas#values DataOciApiaccesscontrolApiMetadatas#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/data-sources/apiaccesscontrol_api_metadatas#regex DataOciApiaccesscontrolApiMetadatas#regex}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciApiaccesscontrolApiMetadatasFilter), fullyQualifiedName: "oci.dataOciApiaccesscontrolApiMetadatas.DataOciApiaccesscontrolApiMetadatasFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciApiaccesscontrolApiMetadatas.IDataOciApiaccesscontrolApiMetadatasFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/data-sources/apiaccesscontrol_api_metadatas#name DataOciApiaccesscontrolApiMetadatas#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/data-sources/apiaccesscontrol_api_metadatas#values DataOciApiaccesscontrolApiMetadatas#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/data-sources/apiaccesscontrol_api_metadatas#regex DataOciApiaccesscontrolApiMetadatas#regex}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
