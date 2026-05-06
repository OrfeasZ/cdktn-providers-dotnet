using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsFleetUncorrelatedPackageManagedInstances
{
    [JsiiInterface(nativeType: typeof(IDataOciJmsFleetUncorrelatedPackageManagedInstancesFilter), fullyQualifiedName: "oci.dataOciJmsFleetUncorrelatedPackageManagedInstances.DataOciJmsFleetUncorrelatedPackageManagedInstancesFilter")]
    public interface IDataOciJmsFleetUncorrelatedPackageManagedInstancesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_uncorrelated_package_managed_instances#name DataOciJmsFleetUncorrelatedPackageManagedInstances#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_uncorrelated_package_managed_instances#values DataOciJmsFleetUncorrelatedPackageManagedInstances#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_uncorrelated_package_managed_instances#regex DataOciJmsFleetUncorrelatedPackageManagedInstances#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciJmsFleetUncorrelatedPackageManagedInstancesFilter), fullyQualifiedName: "oci.dataOciJmsFleetUncorrelatedPackageManagedInstances.DataOciJmsFleetUncorrelatedPackageManagedInstancesFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciJmsFleetUncorrelatedPackageManagedInstances.IDataOciJmsFleetUncorrelatedPackageManagedInstancesFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_uncorrelated_package_managed_instances#name DataOciJmsFleetUncorrelatedPackageManagedInstances#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_uncorrelated_package_managed_instances#values DataOciJmsFleetUncorrelatedPackageManagedInstances#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_uncorrelated_package_managed_instances#regex DataOciJmsFleetUncorrelatedPackageManagedInstances#regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
