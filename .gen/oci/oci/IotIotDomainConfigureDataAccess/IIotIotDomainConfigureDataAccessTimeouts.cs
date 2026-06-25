using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotIotDomainConfigureDataAccess
{
    [JsiiInterface(nativeType: typeof(IIotIotDomainConfigureDataAccessTimeouts), fullyQualifiedName: "oci.iotIotDomainConfigureDataAccess.IotIotDomainConfigureDataAccessTimeouts")]
    public interface IIotIotDomainConfigureDataAccessTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/iot_iot_domain_configure_data_access#create IotIotDomainConfigureDataAccess#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/iot_iot_domain_configure_data_access#delete IotIotDomainConfigureDataAccess#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/iot_iot_domain_configure_data_access#update IotIotDomainConfigureDataAccess#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotIotDomainConfigureDataAccessTimeouts), fullyQualifiedName: "oci.iotIotDomainConfigureDataAccess.IotIotDomainConfigureDataAccessTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.IotIotDomainConfigureDataAccess.IIotIotDomainConfigureDataAccessTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/iot_iot_domain_configure_data_access#create IotIotDomainConfigureDataAccess#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/iot_iot_domain_configure_data_access#delete IotIotDomainConfigureDataAccess#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/iot_iot_domain_configure_data_access#update IotIotDomainConfigureDataAccess#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
