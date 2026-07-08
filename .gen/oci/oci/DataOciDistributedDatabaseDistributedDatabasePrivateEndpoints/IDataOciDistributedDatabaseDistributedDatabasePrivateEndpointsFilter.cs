using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDistributedDatabaseDistributedDatabasePrivateEndpoints
{
    [JsiiInterface(nativeType: typeof(IDataOciDistributedDatabaseDistributedDatabasePrivateEndpointsFilter), fullyQualifiedName: "oci.dataOciDistributedDatabaseDistributedDatabasePrivateEndpoints.DataOciDistributedDatabaseDistributedDatabasePrivateEndpointsFilter")]
    public interface IDataOciDistributedDatabaseDistributedDatabasePrivateEndpointsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/data-sources/distributed_database_distributed_database_private_endpoints#name DataOciDistributedDatabaseDistributedDatabasePrivateEndpoints#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/data-sources/distributed_database_distributed_database_private_endpoints#values DataOciDistributedDatabaseDistributedDatabasePrivateEndpoints#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/data-sources/distributed_database_distributed_database_private_endpoints#regex DataOciDistributedDatabaseDistributedDatabasePrivateEndpoints#regex}.</summary>
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

        [JsiiTypeProxy(nativeType: typeof(IDataOciDistributedDatabaseDistributedDatabasePrivateEndpointsFilter), fullyQualifiedName: "oci.dataOciDistributedDatabaseDistributedDatabasePrivateEndpoints.DataOciDistributedDatabaseDistributedDatabasePrivateEndpointsFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDistributedDatabaseDistributedDatabasePrivateEndpoints.IDataOciDistributedDatabaseDistributedDatabasePrivateEndpointsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/data-sources/distributed_database_distributed_database_private_endpoints#name DataOciDistributedDatabaseDistributedDatabasePrivateEndpoints#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/data-sources/distributed_database_distributed_database_private_endpoints#values DataOciDistributedDatabaseDistributedDatabasePrivateEndpoints#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/data-sources/distributed_database_distributed_database_private_endpoints#regex DataOciDistributedDatabaseDistributedDatabasePrivateEndpoints#regex}.</summary>
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
