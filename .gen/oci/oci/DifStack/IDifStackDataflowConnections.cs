using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    [JsiiInterface(nativeType: typeof(IDifStackDataflowConnections), fullyQualifiedName: "oci.difStack.DifStackDataflowConnections")]
    public interface IDifStackDataflowConnections
    {
        /// <summary>connection_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#connection_details DifStack#connection_details}
        /// </remarks>
        [JsiiProperty(name: "connectionDetails", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowConnectionsConnectionDetails\"}")]
        oci.DifStack.IDifStackDataflowConnectionsConnectionDetails ConnectionDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#subnet_id DifStack#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDifStackDataflowConnections), fullyQualifiedName: "oci.difStack.DifStackDataflowConnections")]
        internal sealed class _Proxy : DeputyBase, oci.DifStack.IDifStackDataflowConnections
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>connection_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#connection_details DifStack#connection_details}
            /// </remarks>
            [JsiiProperty(name: "connectionDetails", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowConnectionsConnectionDetails\"}")]
            public oci.DifStack.IDifStackDataflowConnectionsConnectionDetails ConnectionDetails
            {
                get => GetInstanceProperty<oci.DifStack.IDifStackDataflowConnectionsConnectionDetails>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#subnet_id DifStack#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
