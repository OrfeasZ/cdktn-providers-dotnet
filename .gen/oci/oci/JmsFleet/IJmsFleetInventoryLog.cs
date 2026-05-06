using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsFleet
{
    [JsiiInterface(nativeType: typeof(IJmsFleetInventoryLog), fullyQualifiedName: "oci.jmsFleet.JmsFleetInventoryLog")]
    public interface IJmsFleetInventoryLog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet#log_group_id JmsFleet#log_group_id}.</summary>
        [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string LogGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet#log_id JmsFleet#log_id}.</summary>
        [JsiiProperty(name: "logId", typeJson: "{\"primitive\":\"string\"}")]
        string LogId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IJmsFleetInventoryLog), fullyQualifiedName: "oci.jmsFleet.JmsFleetInventoryLog")]
        internal sealed class _Proxy : DeputyBase, oci.JmsFleet.IJmsFleetInventoryLog
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet#log_group_id JmsFleet#log_group_id}.</summary>
            [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string LogGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet#log_id JmsFleet#log_id}.</summary>
            [JsiiProperty(name: "logId", typeJson: "{\"primitive\":\"string\"}")]
            public string LogId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
