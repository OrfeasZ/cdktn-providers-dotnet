using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataflowSqlEndpoint
{
    [JsiiInterface(nativeType: typeof(IDataflowSqlEndpointNetworkConfigurationAccessControlRules), fullyQualifiedName: "oci.dataflowSqlEndpoint.DataflowSqlEndpointNetworkConfigurationAccessControlRules")]
    public interface IDataflowSqlEndpointNetworkConfigurationAccessControlRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_sql_endpoint#ip_notation DataflowSqlEndpoint#ip_notation}.</summary>
        [JsiiProperty(name: "ipNotation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpNotation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_sql_endpoint#value DataflowSqlEndpoint#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_sql_endpoint#vcn_ips DataflowSqlEndpoint#vcn_ips}.</summary>
        [JsiiProperty(name: "vcnIps", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VcnIps
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataflowSqlEndpointNetworkConfigurationAccessControlRules), fullyQualifiedName: "oci.dataflowSqlEndpoint.DataflowSqlEndpointNetworkConfigurationAccessControlRules")]
        internal sealed class _Proxy : DeputyBase, oci.DataflowSqlEndpoint.IDataflowSqlEndpointNetworkConfigurationAccessControlRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_sql_endpoint#ip_notation DataflowSqlEndpoint#ip_notation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipNotation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpNotation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_sql_endpoint#value DataflowSqlEndpoint#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_sql_endpoint#vcn_ips DataflowSqlEndpoint#vcn_ips}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vcnIps", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VcnIps
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
