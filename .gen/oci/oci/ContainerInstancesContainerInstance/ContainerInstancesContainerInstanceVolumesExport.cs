using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerInstancesContainerInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesExport")]
    public class ContainerInstancesContainerInstanceVolumesExport : oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesExport
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/container_instances_container_instance#id ContainerInstancesContainerInstance#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/container_instances_container_instance#oci_fss_export_type ContainerInstancesContainerInstance#oci_fss_export_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ociFssExportType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OciFssExportType
        {
            get;
            set;
        }
    }
}
