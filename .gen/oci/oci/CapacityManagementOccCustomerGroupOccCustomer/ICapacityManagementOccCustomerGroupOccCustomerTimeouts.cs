using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CapacityManagementOccCustomerGroupOccCustomer
{
    [JsiiInterface(nativeType: typeof(ICapacityManagementOccCustomerGroupOccCustomerTimeouts), fullyQualifiedName: "oci.capacityManagementOccCustomerGroupOccCustomer.CapacityManagementOccCustomerGroupOccCustomerTimeouts")]
    public interface ICapacityManagementOccCustomerGroupOccCustomerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_customer_group_occ_customer#create CapacityManagementOccCustomerGroupOccCustomer#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_customer_group_occ_customer#delete CapacityManagementOccCustomerGroupOccCustomer#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_customer_group_occ_customer#update CapacityManagementOccCustomerGroupOccCustomer#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICapacityManagementOccCustomerGroupOccCustomerTimeouts), fullyQualifiedName: "oci.capacityManagementOccCustomerGroupOccCustomer.CapacityManagementOccCustomerGroupOccCustomerTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.CapacityManagementOccCustomerGroupOccCustomer.ICapacityManagementOccCustomerGroupOccCustomerTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_customer_group_occ_customer#create CapacityManagementOccCustomerGroupOccCustomer#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_customer_group_occ_customer#delete CapacityManagementOccCustomerGroupOccCustomer#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_customer_group_occ_customer#update CapacityManagementOccCustomerGroupOccCustomer#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
