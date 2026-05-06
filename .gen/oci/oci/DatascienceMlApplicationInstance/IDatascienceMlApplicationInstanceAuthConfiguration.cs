using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceMlApplicationInstance
{
    [JsiiInterface(nativeType: typeof(IDatascienceMlApplicationInstanceAuthConfiguration), fullyQualifiedName: "oci.datascienceMlApplicationInstance.DatascienceMlApplicationInstanceAuthConfiguration")]
    public interface IDatascienceMlApplicationInstanceAuthConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_ml_application_instance#type DatascienceMlApplicationInstance#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_ml_application_instance#application_name DatascienceMlApplicationInstance#application_name}.</summary>
        [JsiiProperty(name: "applicationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApplicationName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_ml_application_instance#domain_id DatascienceMlApplicationInstance#domain_id}.</summary>
        [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DomainId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceMlApplicationInstanceAuthConfiguration), fullyQualifiedName: "oci.datascienceMlApplicationInstance.DatascienceMlApplicationInstanceAuthConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceMlApplicationInstance.IDatascienceMlApplicationInstanceAuthConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_ml_application_instance#type DatascienceMlApplicationInstance#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_ml_application_instance#application_name DatascienceMlApplicationInstance#application_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applicationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApplicationName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_ml_application_instance#domain_id DatascienceMlApplicationInstance#domain_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DomainId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
