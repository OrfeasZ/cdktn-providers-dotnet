using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSubsettingPolicySubsettingSchemas
{
    [JsiiInterface(nativeType: typeof(IDataOciDataSafeSubsettingPolicySubsettingSchemasFilter), fullyQualifiedName: "oci.dataOciDataSafeSubsettingPolicySubsettingSchemas.DataOciDataSafeSubsettingPolicySubsettingSchemasFilter")]
    public interface IDataOciDataSafeSubsettingPolicySubsettingSchemasFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/data_safe_subsetting_policy_subsetting_schemas#name DataOciDataSafeSubsettingPolicySubsettingSchemas#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/data_safe_subsetting_policy_subsetting_schemas#values DataOciDataSafeSubsettingPolicySubsettingSchemas#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/data_safe_subsetting_policy_subsetting_schemas#regex DataOciDataSafeSubsettingPolicySubsettingSchemas#regex}.</summary>
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

        [JsiiTypeProxy(nativeType: typeof(IDataOciDataSafeSubsettingPolicySubsettingSchemasFilter), fullyQualifiedName: "oci.dataOciDataSafeSubsettingPolicySubsettingSchemas.DataOciDataSafeSubsettingPolicySubsettingSchemasFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDataSafeSubsettingPolicySubsettingSchemas.IDataOciDataSafeSubsettingPolicySubsettingSchemasFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/data_safe_subsetting_policy_subsetting_schemas#name DataOciDataSafeSubsettingPolicySubsettingSchemas#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/data_safe_subsetting_policy_subsetting_schemas#values DataOciDataSafeSubsettingPolicySubsettingSchemas#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/data_safe_subsetting_policy_subsetting_schemas#regex DataOciDataSafeSubsettingPolicySubsettingSchemas#regex}.</summary>
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
