using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerInstancesContainerInstance
{
    [JsiiInterface(nativeType: typeof(IContainerInstancesContainerInstanceVolumesMountTarget), fullyQualifiedName: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountTarget")]
    public interface IContainerInstancesContainerInstanceVolumesMountTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/container_instances_container_instance#id ContainerInstancesContainerInstance#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/container_instances_container_instance#oci_fss_mount_target_type ContainerInstancesContainerInstance#oci_fss_mount_target_type}.</summary>
        [JsiiProperty(name: "ociFssMountTargetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OciFssMountTargetType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerInstancesContainerInstanceVolumesMountTarget), fullyQualifiedName: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountTarget")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/container_instances_container_instance#id ContainerInstancesContainerInstance#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/container_instances_container_instance#oci_fss_mount_target_type ContainerInstancesContainerInstance#oci_fss_mount_target_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ociFssMountTargetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OciFssMountTargetType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
