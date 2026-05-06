using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreComputeCapacityReservation
{
    [JsiiInterface(nativeType: typeof(ICoreComputeCapacityReservationInstanceReservationConfigsClusterConfig), fullyQualifiedName: "oci.coreComputeCapacityReservation.CoreComputeCapacityReservationInstanceReservationConfigsClusterConfig")]
    public interface ICoreComputeCapacityReservationInstanceReservationConfigsClusterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_reservation#hpc_island_id CoreComputeCapacityReservation#hpc_island_id}.</summary>
        [JsiiProperty(name: "hpcIslandId", typeJson: "{\"primitive\":\"string\"}")]
        string HpcIslandId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_reservation#network_block_ids CoreComputeCapacityReservation#network_block_ids}.</summary>
        [JsiiProperty(name: "networkBlockIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NetworkBlockIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreComputeCapacityReservationInstanceReservationConfigsClusterConfig), fullyQualifiedName: "oci.coreComputeCapacityReservation.CoreComputeCapacityReservationInstanceReservationConfigsClusterConfig")]
        internal sealed class _Proxy : DeputyBase, oci.CoreComputeCapacityReservation.ICoreComputeCapacityReservationInstanceReservationConfigsClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_reservation#hpc_island_id CoreComputeCapacityReservation#hpc_island_id}.</summary>
            [JsiiProperty(name: "hpcIslandId", typeJson: "{\"primitive\":\"string\"}")]
            public string HpcIslandId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_reservation#network_block_ids CoreComputeCapacityReservation#network_block_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkBlockIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NetworkBlockIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
