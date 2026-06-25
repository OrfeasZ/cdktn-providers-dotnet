using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCostadCostAnomalyEventAnalytics
{
    [JsiiInterface(nativeType: typeof(IDataOciCostadCostAnomalyEventAnalyticsConfig), fullyQualifiedName: "oci.dataOciCostadCostAnomalyEventAnalytics.DataOciCostadCostAnomalyEventAnalyticsConfig")]
    public interface IDataOciCostadCostAnomalyEventAnalyticsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/costad_cost_anomaly_event_analytics#compartment_id DataOciCostadCostAnomalyEventAnalytics#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/costad_cost_anomaly_event_analytics#cost_anomaly_monitor_id DataOciCostadCostAnomalyEventAnalytics#cost_anomaly_monitor_id}.</summary>
        [JsiiProperty(name: "costAnomalyMonitorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CostAnomalyMonitorId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/costad_cost_anomaly_event_analytics#cost_impact DataOciCostadCostAnomalyEventAnalytics#cost_impact}.</summary>
        [JsiiProperty(name: "costImpact", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CostImpact
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/costad_cost_anomaly_event_analytics#cost_impact_percentage DataOciCostadCostAnomalyEventAnalytics#cost_impact_percentage}.</summary>
        [JsiiProperty(name: "costImpactPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CostImpactPercentage
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/costad_cost_anomaly_event_analytics#filter DataOciCostadCostAnomalyEventAnalytics#filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciCostadCostAnomalyEventAnalytics.IDataOciCostadCostAnomalyEventAnalyticsFilter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciCostadCostAnomalyEventAnalytics.DataOciCostadCostAnomalyEventAnalyticsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/costad_cost_anomaly_event_analytics#id DataOciCostadCostAnomalyEventAnalytics#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/costad_cost_anomaly_event_analytics#name DataOciCostadCostAnomalyEventAnalytics#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/costad_cost_anomaly_event_analytics#region DataOciCostadCostAnomalyEventAnalytics#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/costad_cost_anomaly_event_analytics#target_tenant_id DataOciCostadCostAnomalyEventAnalytics#target_tenant_id}.</summary>
        [JsiiProperty(name: "targetTenantId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TargetTenantId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/costad_cost_anomaly_event_analytics#time_anomaly_event_end_date DataOciCostadCostAnomalyEventAnalytics#time_anomaly_event_end_date}.</summary>
        [JsiiProperty(name: "timeAnomalyEventEndDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeAnomalyEventEndDate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/costad_cost_anomaly_event_analytics#time_anomaly_event_start_date DataOciCostadCostAnomalyEventAnalytics#time_anomaly_event_start_date}.</summary>
        [JsiiProperty(name: "timeAnomalyEventStartDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeAnomalyEventStartDate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciCostadCostAnomalyEventAnalyticsConfig), fullyQualifiedName: "oci.dataOciCostadCostAnomalyEventAnalytics.DataOciCostadCostAnomalyEventAnalyticsConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciCostadCostAnomalyEventAnalytics.IDataOciCostadCostAnomalyEventAnalyticsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/costad_cost_anomaly_event_analytics#compartment_id DataOciCostadCostAnomalyEventAnalytics#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/costad_cost_anomaly_event_analytics#cost_anomaly_monitor_id DataOciCostadCostAnomalyEventAnalytics#cost_anomaly_monitor_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "costAnomalyMonitorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CostAnomalyMonitorId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/costad_cost_anomaly_event_analytics#cost_impact DataOciCostadCostAnomalyEventAnalytics#cost_impact}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "costImpact", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CostImpact
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/costad_cost_anomaly_event_analytics#cost_impact_percentage DataOciCostadCostAnomalyEventAnalytics#cost_impact_percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "costImpactPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CostImpactPercentage
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/costad_cost_anomaly_event_analytics#filter DataOciCostadCostAnomalyEventAnalytics#filter}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciCostadCostAnomalyEventAnalytics.IDataOciCostadCostAnomalyEventAnalyticsFilter" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciCostadCostAnomalyEventAnalytics.DataOciCostadCostAnomalyEventAnalyticsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Filter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/costad_cost_anomaly_event_analytics#id DataOciCostadCostAnomalyEventAnalytics#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/costad_cost_anomaly_event_analytics#name DataOciCostadCostAnomalyEventAnalytics#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/costad_cost_anomaly_event_analytics#region DataOciCostadCostAnomalyEventAnalytics#region}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Region
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/costad_cost_anomaly_event_analytics#target_tenant_id DataOciCostadCostAnomalyEventAnalytics#target_tenant_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetTenantId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TargetTenantId
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/costad_cost_anomaly_event_analytics#time_anomaly_event_end_date DataOciCostadCostAnomalyEventAnalytics#time_anomaly_event_end_date}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeAnomalyEventEndDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeAnomalyEventEndDate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/costad_cost_anomaly_event_analytics#time_anomaly_event_start_date DataOciCostadCostAnomalyEventAnalytics#time_anomaly_event_start_date}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeAnomalyEventStartDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeAnomalyEventStartDate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
