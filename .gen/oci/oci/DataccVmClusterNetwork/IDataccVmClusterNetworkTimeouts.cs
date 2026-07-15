using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataccVmClusterNetwork
{
    [JsiiInterface(nativeType: typeof(IDataccVmClusterNetworkTimeouts), fullyQualifiedName: "oci.dataccVmClusterNetwork.DataccVmClusterNetworkTimeouts")]
    public interface IDataccVmClusterNetworkTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datacc_vm_cluster_network#create DataccVmClusterNetwork#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datacc_vm_cluster_network#delete DataccVmClusterNetwork#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datacc_vm_cluster_network#update DataccVmClusterNetwork#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataccVmClusterNetworkTimeouts), fullyQualifiedName: "oci.dataccVmClusterNetwork.DataccVmClusterNetworkTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DataccVmClusterNetwork.IDataccVmClusterNetworkTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datacc_vm_cluster_network#create DataccVmClusterNetwork#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datacc_vm_cluster_network#delete DataccVmClusterNetwork#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datacc_vm_cluster_network#update DataccVmClusterNetwork#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
