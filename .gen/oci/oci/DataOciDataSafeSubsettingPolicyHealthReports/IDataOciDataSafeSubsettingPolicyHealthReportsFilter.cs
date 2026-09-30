using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSubsettingPolicyHealthReports
{
    [JsiiInterface(nativeType: typeof(IDataOciDataSafeSubsettingPolicyHealthReportsFilter), fullyQualifiedName: "oci.dataOciDataSafeSubsettingPolicyHealthReports.DataOciDataSafeSubsettingPolicyHealthReportsFilter")]
    public interface IDataOciDataSafeSubsettingPolicyHealthReportsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/data-sources/data_safe_subsetting_policy_health_reports#name DataOciDataSafeSubsettingPolicyHealthReports#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/data-sources/data_safe_subsetting_policy_health_reports#values DataOciDataSafeSubsettingPolicyHealthReports#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/data-sources/data_safe_subsetting_policy_health_reports#regex DataOciDataSafeSubsettingPolicyHealthReports#regex}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciDataSafeSubsettingPolicyHealthReportsFilter), fullyQualifiedName: "oci.dataOciDataSafeSubsettingPolicyHealthReports.DataOciDataSafeSubsettingPolicyHealthReportsFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDataSafeSubsettingPolicyHealthReports.IDataOciDataSafeSubsettingPolicyHealthReportsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/data-sources/data_safe_subsetting_policy_health_reports#name DataOciDataSafeSubsettingPolicyHealthReports#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/data-sources/data_safe_subsetting_policy_health_reports#values DataOciDataSafeSubsettingPolicyHealthReports#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/data-sources/data_safe_subsetting_policy_health_reports#regex DataOciDataSafeSubsettingPolicyHealthReports#regex}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
