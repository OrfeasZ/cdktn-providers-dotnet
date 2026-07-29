using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotIotDomainChangeDataRetentionPeriod
{
    [JsiiInterface(nativeType: typeof(IIotIotDomainChangeDataRetentionPeriodTimeouts), fullyQualifiedName: "oci.iotIotDomainChangeDataRetentionPeriod.IotIotDomainChangeDataRetentionPeriodTimeouts")]
    public interface IIotIotDomainChangeDataRetentionPeriodTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/iot_iot_domain_change_data_retention_period#create IotIotDomainChangeDataRetentionPeriod#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/iot_iot_domain_change_data_retention_period#delete IotIotDomainChangeDataRetentionPeriod#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/iot_iot_domain_change_data_retention_period#update IotIotDomainChangeDataRetentionPeriod#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotIotDomainChangeDataRetentionPeriodTimeouts), fullyQualifiedName: "oci.iotIotDomainChangeDataRetentionPeriod.IotIotDomainChangeDataRetentionPeriodTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.IotIotDomainChangeDataRetentionPeriod.IIotIotDomainChangeDataRetentionPeriodTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/iot_iot_domain_change_data_retention_period#create IotIotDomainChangeDataRetentionPeriod#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/iot_iot_domain_change_data_retention_period#delete IotIotDomainChangeDataRetentionPeriod#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/iot_iot_domain_change_data_retention_period#update IotIotDomainChangeDataRetentionPeriod#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
