using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    [JsiiInterface(nativeType: typeof(IDifStackGgcsConnectionsDifDependencies), fullyQualifiedName: "oci.difStack.DifStackGgcsConnectionsDifDependencies")]
    public interface IDifStackGgcsConnectionsDifDependencies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#service_instance_id DifStack#service_instance_id}.</summary>
        [JsiiProperty(name: "serviceInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceInstanceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#service_type DifStack#service_type}.</summary>
        [JsiiProperty(name: "serviceType", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDifStackGgcsConnectionsDifDependencies), fullyQualifiedName: "oci.difStack.DifStackGgcsConnectionsDifDependencies")]
        internal sealed class _Proxy : DeputyBase, oci.DifStack.IDifStackGgcsConnectionsDifDependencies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#service_instance_id DifStack#service_instance_id}.</summary>
            [JsiiProperty(name: "serviceInstanceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceInstanceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#service_type DifStack#service_type}.</summary>
            [JsiiProperty(name: "serviceType", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
