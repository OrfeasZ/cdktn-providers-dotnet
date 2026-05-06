using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotDigitalTwinAdapter
{
    [JsiiInterface(nativeType: typeof(IIotDigitalTwinAdapterInboundRoutes), fullyQualifiedName: "oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundRoutes")]
    public interface IIotDigitalTwinAdapterInboundRoutes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#condition IotDigitalTwinAdapter#condition}.</summary>
        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}")]
        string Condition
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#description IotDigitalTwinAdapter#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#payload_mapping IotDigitalTwinAdapter#payload_mapping}.</summary>
        [JsiiProperty(name: "payloadMapping", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? PayloadMapping
        {
            get
            {
                return null;
            }
        }

        /// <summary>reference_payload block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#reference_payload IotDigitalTwinAdapter#reference_payload}
        /// </remarks>
        [JsiiProperty(name: "referencePayload", typeJson: "{\"fqn\":\"oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundRoutesReferencePayload\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundRoutesReferencePayload? ReferencePayload
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotDigitalTwinAdapterInboundRoutes), fullyQualifiedName: "oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundRoutes")]
        internal sealed class _Proxy : DeputyBase, oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundRoutes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#condition IotDigitalTwinAdapter#condition}.</summary>
            [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}")]
            public string Condition
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#description IotDigitalTwinAdapter#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#payload_mapping IotDigitalTwinAdapter#payload_mapping}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "payloadMapping", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? PayloadMapping
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>reference_payload block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#reference_payload IotDigitalTwinAdapter#reference_payload}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "referencePayload", typeJson: "{\"fqn\":\"oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundRoutesReferencePayload\"}", isOptional: true)]
            public oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundRoutesReferencePayload? ReferencePayload
            {
                get => GetInstanceProperty<oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundRoutesReferencePayload?>();
            }
        }
    }
}
