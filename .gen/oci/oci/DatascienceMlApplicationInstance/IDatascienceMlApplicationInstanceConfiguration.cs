using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceMlApplicationInstance
{
    [JsiiInterface(nativeType: typeof(IDatascienceMlApplicationInstanceConfiguration), fullyQualifiedName: "oci.datascienceMlApplicationInstance.DatascienceMlApplicationInstanceConfiguration")]
    public interface IDatascienceMlApplicationInstanceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_ml_application_instance#key DatascienceMlApplicationInstance#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_ml_application_instance#value DatascienceMlApplicationInstance#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceMlApplicationInstanceConfiguration), fullyQualifiedName: "oci.datascienceMlApplicationInstance.DatascienceMlApplicationInstanceConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceMlApplicationInstance.IDatascienceMlApplicationInstanceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_ml_application_instance#key DatascienceMlApplicationInstance#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_ml_application_instance#value DatascienceMlApplicationInstance#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
