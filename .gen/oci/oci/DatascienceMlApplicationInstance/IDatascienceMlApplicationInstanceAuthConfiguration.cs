using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceMlApplicationInstance
{
    [JsiiInterface(nativeType: typeof(IDatascienceMlApplicationInstanceAuthConfiguration), fullyQualifiedName: "oci.datascienceMlApplicationInstance.DatascienceMlApplicationInstanceAuthConfiguration")]
    public interface IDatascienceMlApplicationInstanceAuthConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datascience_ml_application_instance#type DatascienceMlApplicationInstance#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceMlApplicationInstanceAuthConfiguration), fullyQualifiedName: "oci.datascienceMlApplicationInstance.DatascienceMlApplicationInstanceAuthConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceMlApplicationInstance.IDatascienceMlApplicationInstanceAuthConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datascience_ml_application_instance#type DatascienceMlApplicationInstance#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
