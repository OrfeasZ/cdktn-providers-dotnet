using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceFastLaunchJobConfigs
{
    [JsiiInterface(nativeType: typeof(IDataOciDatascienceFastLaunchJobConfigsFilter), fullyQualifiedName: "oci.dataOciDatascienceFastLaunchJobConfigs.DataOciDatascienceFastLaunchJobConfigsFilter")]
    public interface IDataOciDatascienceFastLaunchJobConfigsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_fast_launch_job_configs#name DataOciDatascienceFastLaunchJobConfigs#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_fast_launch_job_configs#values DataOciDatascienceFastLaunchJobConfigs#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_fast_launch_job_configs#regex DataOciDatascienceFastLaunchJobConfigs#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciDatascienceFastLaunchJobConfigsFilter), fullyQualifiedName: "oci.dataOciDatascienceFastLaunchJobConfigs.DataOciDatascienceFastLaunchJobConfigsFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDatascienceFastLaunchJobConfigs.IDataOciDatascienceFastLaunchJobConfigsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_fast_launch_job_configs#name DataOciDatascienceFastLaunchJobConfigs#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_fast_launch_job_configs#values DataOciDatascienceFastLaunchJobConfigs#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_fast_launch_job_configs#regex DataOciDatascienceFastLaunchJobConfigs#regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
