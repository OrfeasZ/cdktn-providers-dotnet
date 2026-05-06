using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SchServiceConnector
{
    [JsiiInterface(nativeType: typeof(ISchServiceConnectorSourceLogSources), fullyQualifiedName: "oci.schServiceConnector.SchServiceConnectorSourceLogSources")]
    public interface ISchServiceConnectorSourceLogSources
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#compartment_id SchServiceConnector#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompartmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#log_group_id SchServiceConnector#log_group_id}.</summary>
        [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#log_id SchServiceConnector#log_id}.</summary>
        [JsiiProperty(name: "logId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISchServiceConnectorSourceLogSources), fullyQualifiedName: "oci.schServiceConnector.SchServiceConnectorSourceLogSources")]
        internal sealed class _Proxy : DeputyBase, oci.SchServiceConnector.ISchServiceConnectorSourceLogSources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#compartment_id SchServiceConnector#compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#log_group_id SchServiceConnector#log_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#log_id SchServiceConnector#log_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
