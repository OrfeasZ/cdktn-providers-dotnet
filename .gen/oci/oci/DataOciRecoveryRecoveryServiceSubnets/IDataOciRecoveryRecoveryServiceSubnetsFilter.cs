using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciRecoveryRecoveryServiceSubnets
{
    [JsiiInterface(nativeType: typeof(IDataOciRecoveryRecoveryServiceSubnetsFilter), fullyQualifiedName: "oci.dataOciRecoveryRecoveryServiceSubnets.DataOciRecoveryRecoveryServiceSubnetsFilter")]
    public interface IDataOciRecoveryRecoveryServiceSubnetsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/recovery_recovery_service_subnets#name DataOciRecoveryRecoveryServiceSubnets#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/recovery_recovery_service_subnets#values DataOciRecoveryRecoveryServiceSubnets#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/recovery_recovery_service_subnets#regex DataOciRecoveryRecoveryServiceSubnets#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciRecoveryRecoveryServiceSubnetsFilter), fullyQualifiedName: "oci.dataOciRecoveryRecoveryServiceSubnets.DataOciRecoveryRecoveryServiceSubnetsFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciRecoveryRecoveryServiceSubnets.IDataOciRecoveryRecoveryServiceSubnetsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/recovery_recovery_service_subnets#name DataOciRecoveryRecoveryServiceSubnets#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/recovery_recovery_service_subnets#values DataOciRecoveryRecoveryServiceSubnets#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/recovery_recovery_service_subnets#regex DataOciRecoveryRecoveryServiceSubnets#regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
