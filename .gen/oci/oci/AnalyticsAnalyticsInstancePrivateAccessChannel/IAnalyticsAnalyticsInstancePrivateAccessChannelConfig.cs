using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AnalyticsAnalyticsInstancePrivateAccessChannel
{
    [JsiiInterface(nativeType: typeof(IAnalyticsAnalyticsInstancePrivateAccessChannelConfig), fullyQualifiedName: "oci.analyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelConfig")]
    public interface IAnalyticsAnalyticsInstancePrivateAccessChannelConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#analytics_instance_id AnalyticsAnalyticsInstancePrivateAccessChannel#analytics_instance_id}.</summary>
        [JsiiProperty(name: "analyticsInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        string AnalyticsInstanceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#display_name AnalyticsAnalyticsInstancePrivateAccessChannel#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>private_source_dns_zones block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#private_source_dns_zones AnalyticsAnalyticsInstancePrivateAccessChannel#private_source_dns_zones}
        /// </remarks>
        [JsiiProperty(name: "privateSourceDnsZones", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.analyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceDnsZones\"},\"kind\":\"array\"}}]}}")]
        object PrivateSourceDnsZones
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#subnet_id AnalyticsAnalyticsInstancePrivateAccessChannel#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#vcn_id AnalyticsAnalyticsInstancePrivateAccessChannel#vcn_id}.</summary>
        [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}")]
        string VcnId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#id AnalyticsAnalyticsInstancePrivateAccessChannel#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#network_security_group_ids AnalyticsAnalyticsInstancePrivateAccessChannel#network_security_group_ids}.</summary>
        [JsiiProperty(name: "networkSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NetworkSecurityGroupIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>private_source_scan_hosts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#private_source_scan_hosts AnalyticsAnalyticsInstancePrivateAccessChannel#private_source_scan_hosts}
        /// </remarks>
        [JsiiProperty(name: "privateSourceScanHosts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.analyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceScanHosts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrivateSourceScanHosts
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#timeouts AnalyticsAnalyticsInstancePrivateAccessChannel#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.analyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.AnalyticsAnalyticsInstancePrivateAccessChannel.IAnalyticsAnalyticsInstancePrivateAccessChannelTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAnalyticsAnalyticsInstancePrivateAccessChannelConfig), fullyQualifiedName: "oci.analyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelConfig")]
        internal sealed class _Proxy : DeputyBase, oci.AnalyticsAnalyticsInstancePrivateAccessChannel.IAnalyticsAnalyticsInstancePrivateAccessChannelConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#analytics_instance_id AnalyticsAnalyticsInstancePrivateAccessChannel#analytics_instance_id}.</summary>
            [JsiiProperty(name: "analyticsInstanceId", typeJson: "{\"primitive\":\"string\"}")]
            public string AnalyticsInstanceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#display_name AnalyticsAnalyticsInstancePrivateAccessChannel#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>private_source_dns_zones block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#private_source_dns_zones AnalyticsAnalyticsInstancePrivateAccessChannel#private_source_dns_zones}
            /// </remarks>
            [JsiiProperty(name: "privateSourceDnsZones", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.analyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceDnsZones\"},\"kind\":\"array\"}}]}}")]
            public object PrivateSourceDnsZones
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#subnet_id AnalyticsAnalyticsInstancePrivateAccessChannel#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#vcn_id AnalyticsAnalyticsInstancePrivateAccessChannel#vcn_id}.</summary>
            [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}")]
            public string VcnId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#id AnalyticsAnalyticsInstancePrivateAccessChannel#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#network_security_group_ids AnalyticsAnalyticsInstancePrivateAccessChannel#network_security_group_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NetworkSecurityGroupIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>private_source_scan_hosts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#private_source_scan_hosts AnalyticsAnalyticsInstancePrivateAccessChannel#private_source_scan_hosts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateSourceScanHosts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.analyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceScanHosts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PrivateSourceScanHosts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#timeouts AnalyticsAnalyticsInstancePrivateAccessChannel#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.analyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelTimeouts\"}", isOptional: true)]
            public oci.AnalyticsAnalyticsInstancePrivateAccessChannel.IAnalyticsAnalyticsInstancePrivateAccessChannelTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.AnalyticsAnalyticsInstancePrivateAccessChannel.IAnalyticsAnalyticsInstancePrivateAccessChannelTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
