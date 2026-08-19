using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceBdsCertificateConfiguration
{
    [JsiiInterface(nativeType: typeof(IBdsBdsInstanceBdsCertificateConfigurationTimeouts), fullyQualifiedName: "oci.bdsBdsInstanceBdsCertificateConfiguration.BdsBdsInstanceBdsCertificateConfigurationTimeouts")]
    public interface IBdsBdsInstanceBdsCertificateConfigurationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/bds_bds_instance_bds_certificate_configuration#create BdsBdsInstanceBdsCertificateConfiguration#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/bds_bds_instance_bds_certificate_configuration#delete BdsBdsInstanceBdsCertificateConfiguration#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/bds_bds_instance_bds_certificate_configuration#update BdsBdsInstanceBdsCertificateConfiguration#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsBdsInstanceBdsCertificateConfigurationTimeouts), fullyQualifiedName: "oci.bdsBdsInstanceBdsCertificateConfiguration.BdsBdsInstanceBdsCertificateConfigurationTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.BdsBdsInstanceBdsCertificateConfiguration.IBdsBdsInstanceBdsCertificateConfigurationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/bds_bds_instance_bds_certificate_configuration#create BdsBdsInstanceBdsCertificateConfiguration#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/bds_bds_instance_bds_certificate_configuration#delete BdsBdsInstanceBdsCertificateConfiguration#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/bds_bds_instance_bds_certificate_configuration#update BdsBdsInstanceBdsCertificateConfiguration#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
