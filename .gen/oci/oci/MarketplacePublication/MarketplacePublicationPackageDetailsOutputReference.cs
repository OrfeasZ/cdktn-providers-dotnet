using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MarketplacePublication
{
    [JsiiClass(nativeType: typeof(oci.MarketplacePublication.MarketplacePublicationPackageDetailsOutputReference), fullyQualifiedName: "oci.marketplacePublication.MarketplacePublicationPackageDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MarketplacePublicationPackageDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MarketplacePublicationPackageDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MarketplacePublicationPackageDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MarketplacePublicationPackageDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEula", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.marketplacePublication.MarketplacePublicationPackageDetailsEula\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEula(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.MarketplacePublication.IMarketplacePublicationPackageDetailsEula[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MarketplacePublication.IMarketplacePublicationPackageDetailsEula).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MarketplacePublication.IMarketplacePublicationPackageDetailsEula).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOperatingSystem", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.marketplacePublication.MarketplacePublicationPackageDetailsOperatingSystem\"}}]")]
        public virtual void PutOperatingSystem(oci.MarketplacePublication.IMarketplacePublicationPackageDetailsOperatingSystem @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.MarketplacePublication.IMarketplacePublicationPackageDetailsOperatingSystem)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetImageId")]
        public virtual void ResetImageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "eula", typeJson: "{\"fqn\":\"oci.marketplacePublication.MarketplacePublicationPackageDetailsEulaList\"}")]
        public virtual oci.MarketplacePublication.MarketplacePublicationPackageDetailsEulaList Eula
        {
            get => GetInstanceProperty<oci.MarketplacePublication.MarketplacePublicationPackageDetailsEulaList>()!;
        }

        [JsiiProperty(name: "operatingSystem", typeJson: "{\"fqn\":\"oci.marketplacePublication.MarketplacePublicationPackageDetailsOperatingSystemOutputReference\"}")]
        public virtual oci.MarketplacePublication.MarketplacePublicationPackageDetailsOperatingSystemOutputReference OperatingSystem
        {
            get => GetInstanceProperty<oci.MarketplacePublication.MarketplacePublicationPackageDetailsOperatingSystemOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "eulaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.marketplacePublication.MarketplacePublicationPackageDetailsEula\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EulaInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "operatingSystemInput", typeJson: "{\"fqn\":\"oci.marketplacePublication.MarketplacePublicationPackageDetailsOperatingSystem\"}", isOptional: true)]
        public virtual oci.MarketplacePublication.IMarketplacePublicationPackageDetailsOperatingSystem? OperatingSystemInput
        {
            get => GetInstanceProperty<oci.MarketplacePublication.IMarketplacePublicationPackageDetailsOperatingSystem?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "packageTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PackageTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "packageVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PackageVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "packageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "packageVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.marketplacePublication.MarketplacePublicationPackageDetails\"}", isOptional: true)]
        public virtual oci.MarketplacePublication.IMarketplacePublicationPackageDetails? InternalValue
        {
            get => GetInstanceProperty<oci.MarketplacePublication.IMarketplacePublicationPackageDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
