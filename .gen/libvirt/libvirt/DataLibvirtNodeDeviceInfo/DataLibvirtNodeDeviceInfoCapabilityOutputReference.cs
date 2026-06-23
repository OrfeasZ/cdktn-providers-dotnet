using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.DataLibvirtNodeDeviceInfo
{
    [JsiiClass(nativeType: typeof(libvirt.DataLibvirtNodeDeviceInfo.DataLibvirtNodeDeviceInfoCapabilityOutputReference), fullyQualifiedName: "libvirt.dataLibvirtNodeDeviceInfo.DataLibvirtNodeDeviceInfoCapabilityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataLibvirtNodeDeviceInfoCapabilityOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataLibvirtNodeDeviceInfoCapabilityOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataLibvirtNodeDeviceInfoCapabilityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataLibvirtNodeDeviceInfoCapabilityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Address
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "block", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Block
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Bus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "class", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Class
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deviceNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeviceNumber
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Domain
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "driveType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DriveType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "function", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Function
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Host
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "interface", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Interface
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "iommuGroup", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IommuGroup
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "linkSpeed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LinkSpeed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "linkState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LinkState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logicalBlockSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LogicalBlockSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "lun", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Lun
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Model
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "numBlocks", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumBlocks
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "productId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "productName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scsiType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScsiType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serial", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Serial
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Size
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "slot", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Slot
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Target
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vendorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VendorId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vendorName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VendorName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"libvirt.dataLibvirtNodeDeviceInfo.DataLibvirtNodeDeviceInfoCapability\"}", isOptional: true)]
        public virtual libvirt.DataLibvirtNodeDeviceInfo.IDataLibvirtNodeDeviceInfoCapability? InternalValue
        {
            get => GetInstanceProperty<libvirt.DataLibvirtNodeDeviceInfo.IDataLibvirtNodeDeviceInfoCapability?>();
            set => SetInstanceProperty(value);
        }
    }
}
