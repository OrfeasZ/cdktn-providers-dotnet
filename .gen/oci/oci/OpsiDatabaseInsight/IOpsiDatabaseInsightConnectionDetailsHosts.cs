using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpsiDatabaseInsight
{
    [JsiiInterface(nativeType: typeof(IOpsiDatabaseInsightConnectionDetailsHosts), fullyQualifiedName: "oci.opsiDatabaseInsight.OpsiDatabaseInsightConnectionDetailsHosts")]
    public interface IOpsiDatabaseInsightConnectionDetailsHosts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#host_ip OpsiDatabaseInsight#host_ip}.</summary>
        [JsiiProperty(name: "hostIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#port OpsiDatabaseInsight#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsiDatabaseInsightConnectionDetailsHosts), fullyQualifiedName: "oci.opsiDatabaseInsight.OpsiDatabaseInsightConnectionDetailsHosts")]
        internal sealed class _Proxy : DeputyBase, oci.OpsiDatabaseInsight.IOpsiDatabaseInsightConnectionDetailsHosts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#host_ip OpsiDatabaseInsight#host_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#port OpsiDatabaseInsight#port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
