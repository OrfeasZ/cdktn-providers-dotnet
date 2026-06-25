using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiClass(nativeType: typeof(oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesOutputReference), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudBridgeAssetAwsEc2NetworkInterfacesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CloudBridgeAssetAwsEc2NetworkInterfacesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudBridgeAssetAwsEc2NetworkInterfacesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudBridgeAssetAwsEc2NetworkInterfacesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAssociation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAssociation\"}}]")]
        public virtual void PutAssociation(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesAssociation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesAssociation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAttachment", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAttachment\"}}]")]
        public virtual void PutAttachment(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesAttachment @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesAttachment)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddresses" />)[]</param>
        [JsiiMethod(name: "putPrivateIpAddresses", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddresses\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPrivateIpAddresses(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddresses[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddresses).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddresses).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesSecurityGroups" />)[]</param>
        [JsiiMethod(name: "putSecurityGroups", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesSecurityGroups\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSecurityGroups(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesSecurityGroups[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesSecurityGroups).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesSecurityGroups).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAssociation")]
        public virtual void ResetAssociation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAttachment")]
        public virtual void ResetAttachment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInterfaceType")]
        public virtual void ResetInterfaceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpv4Prefixes")]
        public virtual void ResetIpv4Prefixes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpv6Addresses")]
        public virtual void ResetIpv6Addresses()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpv6Prefixes")]
        public virtual void ResetIpv6Prefixes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsSourceDestCheck")]
        public virtual void ResetIsSourceDestCheck()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMacAddress")]
        public virtual void ResetMacAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkInterfaceKey")]
        public virtual void ResetNetworkInterfaceKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOwnerKey")]
        public virtual void ResetOwnerKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateIpAddresses")]
        public virtual void ResetPrivateIpAddresses()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityGroups")]
        public virtual void ResetSecurityGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatus")]
        public virtual void ResetStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetKey")]
        public virtual void ResetSubnetKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "association", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAssociationOutputReference\"}")]
        public virtual oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAssociationOutputReference Association
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAssociationOutputReference>()!;
        }

        [JsiiProperty(name: "attachment", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAttachmentOutputReference\"}")]
        public virtual oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAttachmentOutputReference Attachment
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAttachmentOutputReference>()!;
        }

        [JsiiProperty(name: "privateIpAddresses", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddressesList\"}")]
        public virtual oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddressesList PrivateIpAddresses
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddressesList>()!;
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesSecurityGroupsList\"}")]
        public virtual oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesSecurityGroupsList SecurityGroups
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesSecurityGroupsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "associationInput", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAssociation\"}", isOptional: true)]
        public virtual oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesAssociation? AssociationInput
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesAssociation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "attachmentInput", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAttachment\"}", isOptional: true)]
        public virtual oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesAttachment? AttachmentInput
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesAttachment?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "interfaceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InterfaceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv4PrefixesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? Ipv4PrefixesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv6AddressesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? Ipv6AddressesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv6PrefixesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? Ipv6PrefixesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isSourceDestCheckInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsSourceDestCheckInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "macAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MacAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkInterfaceKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ownerKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OwnerKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddresses" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "privateIpAddressesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesPrivateIpAddresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PrivateIpAddressesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesSecurityGroups" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroupsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesSecurityGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SecurityGroupsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "interfaceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InterfaceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipv4Prefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Ipv4Prefixes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipv6Addresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Ipv6Addresses
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipv6Prefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Ipv6Prefixes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isSourceDestCheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsSourceDestCheck
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "macAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MacAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkInterfaceKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkInterfaceKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ownerKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfaces" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfaces\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfaces cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfaces).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
