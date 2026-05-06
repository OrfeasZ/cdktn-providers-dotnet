using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DesktopsDesktopPool
{
    [JsiiInterface(nativeType: typeof(IDesktopsDesktopPoolImage), fullyQualifiedName: "oci.desktopsDesktopPool.DesktopsDesktopPoolImage")]
    public interface IDesktopsDesktopPoolImage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#image_id DesktopsDesktopPool#image_id}.</summary>
        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}")]
        string ImageId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#image_name DesktopsDesktopPool#image_name}.</summary>
        [JsiiProperty(name: "imageName", typeJson: "{\"primitive\":\"string\"}")]
        string ImageName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#operating_system DesktopsDesktopPool#operating_system}.</summary>
        [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OperatingSystem
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDesktopsDesktopPoolImage), fullyQualifiedName: "oci.desktopsDesktopPool.DesktopsDesktopPoolImage")]
        internal sealed class _Proxy : DeputyBase, oci.DesktopsDesktopPool.IDesktopsDesktopPoolImage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#image_id DesktopsDesktopPool#image_id}.</summary>
            [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}")]
            public string ImageId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#image_name DesktopsDesktopPool#image_name}.</summary>
            [JsiiProperty(name: "imageName", typeJson: "{\"primitive\":\"string\"}")]
            public string ImageName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#operating_system DesktopsDesktopPool#operating_system}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OperatingSystem
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
