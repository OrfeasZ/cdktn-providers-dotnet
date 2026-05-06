using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DesktopsDesktopPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.desktopsDesktopPool.DesktopsDesktopPoolImage")]
    public class DesktopsDesktopPoolImage : oci.DesktopsDesktopPool.IDesktopsDesktopPoolImage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#image_id DesktopsDesktopPool#image_id}.</summary>
        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}")]
        public string ImageId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#image_name DesktopsDesktopPool#image_name}.</summary>
        [JsiiProperty(name: "imageName", typeJson: "{\"primitive\":\"string\"}")]
        public string ImageName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#operating_system DesktopsDesktopPool#operating_system}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OperatingSystem
        {
            get;
            set;
        }
    }
}
