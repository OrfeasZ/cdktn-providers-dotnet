using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiClass(nativeType: typeof(oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2OutputReference), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudBridgeAssetAwsEc2OutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudBridgeAssetAwsEc2OutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudBridgeAssetAwsEc2OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudBridgeAssetAwsEc2OutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfaces" />)[]</param>
        [JsiiMethod(name: "putNetworkInterfaces", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfaces\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkInterfaces(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfaces[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfaces).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfaces).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlacement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2Placement\"}}]")]
        public virtual void PutPlacement(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2Placement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2Placement)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2SecurityGroups" />)[]</param>
        [JsiiMethod(name: "putSecurityGroups", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2SecurityGroups\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSecurityGroups(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2SecurityGroups[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2SecurityGroups).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2SecurityGroups).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putState", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2State\"}}]")]
        public virtual void PutState(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2State @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2State)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2Tags" />)[]</param>
        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2Tags\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTags(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2Tags[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2Tags).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2Tags).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetArchitecture")]
        public virtual void ResetArchitecture()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAreElasticInferenceAcceleratorsPresent")]
        public virtual void ResetAreElasticInferenceAcceleratorsPresent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBootMode")]
        public virtual void ResetBootMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapacityReservationKey")]
        public virtual void ResetCapacityReservationKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageKey")]
        public virtual void ResetImageKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceKey")]
        public virtual void ResetInstanceKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceLifecycle")]
        public virtual void ResetInstanceLifecycle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceType")]
        public virtual void ResetInstanceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpAddress")]
        public virtual void ResetIpAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpv6Address")]
        public virtual void ResetIpv6Address()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsEnclaveOptions")]
        public virtual void ResetIsEnclaveOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsHibernationOptions")]
        public virtual void ResetIsHibernationOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsSourceDestCheck")]
        public virtual void ResetIsSourceDestCheck()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsSpotInstance")]
        public virtual void ResetIsSpotInstance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKernelKey")]
        public virtual void ResetKernelKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLicenses")]
        public virtual void ResetLicenses()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceOptions")]
        public virtual void ResetMaintenanceOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonitoring")]
        public virtual void ResetMonitoring()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkInterfaces")]
        public virtual void ResetNetworkInterfaces()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacement")]
        public virtual void ResetPlacement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateDnsName")]
        public virtual void ResetPrivateDnsName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateIpAddress")]
        public virtual void ResetPrivateIpAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRootDeviceName")]
        public virtual void ResetRootDeviceName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRootDeviceType")]
        public virtual void ResetRootDeviceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityGroups")]
        public virtual void ResetSecurityGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSriovNetSupport")]
        public virtual void ResetSriovNetSupport()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetKey")]
        public virtual void ResetSubnetKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeLaunch")]
        public virtual void ResetTimeLaunch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTpmSupport")]
        public virtual void ResetTpmSupport()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVirtualizationType")]
        public virtual void ResetVirtualizationType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcKey")]
        public virtual void ResetVpcKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "networkInterfaces", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesList\"}")]
        public virtual oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesList NetworkInterfaces
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesList>()!;
        }

        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2PlacementOutputReference\"}")]
        public virtual oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2PlacementOutputReference Placement
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2PlacementOutputReference>()!;
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2SecurityGroupsList\"}")]
        public virtual oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2SecurityGroupsList SecurityGroups
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2SecurityGroupsList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2StateOutputReference\"}")]
        public virtual oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2StateOutputReference State
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2StateOutputReference>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2TagsList\"}")]
        public virtual oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2TagsList Tags
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2TagsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "architectureInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArchitectureInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "areElasticInferenceAcceleratorsPresentInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AreElasticInferenceAcceleratorsPresentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BootModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CapacityReservationKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceLifecycleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceLifecycleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv6AddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Ipv6AddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isEnclaveOptionsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsEnclaveOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isHibernationOptionsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsHibernationOptionsInput
        {
            get => GetInstanceProperty<object?>();
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isSpotInstanceInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsSpotInstanceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kernelKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KernelKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "licensesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? LicensesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceOptionsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaintenanceOptionsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitoringInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MonitoringInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfaces" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkInterfacesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkInterfacesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementInput", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2Placement\"}", isOptional: true)]
        public virtual oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2Placement? PlacementInput
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2Placement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateDnsNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivateDnsNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateIpAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivateIpAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootDeviceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RootDeviceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootDeviceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RootDeviceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2SecurityGroups" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroupsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2SecurityGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SecurityGroupsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sriovNetSupportInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SriovNetSupportInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2State\"}", isOptional: true)]
        public virtual oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2State? StateInput
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2State?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2Tags" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2Tags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeLaunchInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeLaunchInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tpmSupportInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TpmSupportInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualizationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VirtualizationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VpcKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Architecture
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "areElasticInferenceAcceleratorsPresent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AreElasticInferenceAcceleratorsPresent
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

        [JsiiProperty(name: "bootMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "capacityReservationKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityReservationKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceLifecycle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceLifecycle
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipv6Address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv6Address
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isEnclaveOptions", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsEnclaveOptions
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isHibernationOptions", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsHibernationOptions
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isSpotInstance", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsSpotInstance
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

        [JsiiProperty(name: "kernelKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KernelKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "licenses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Licenses
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maintenanceOptions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceOptions
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "monitoring", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Monitoring
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privateDnsName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateDnsName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privateIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateIpAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rootDeviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootDeviceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rootDeviceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootDeviceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sriovNetSupport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SriovNetSupport
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

        [JsiiProperty(name: "timeLaunch", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLaunch
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tpmSupport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TpmSupport
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "virtualizationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualizationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2\"}", isOptional: true)]
        public virtual oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2? InternalValue
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2?>();
            set => SetInstanceProperty(value);
        }
    }
}
