using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudMigrationsTargetAsset
{
    [JsiiClass(nativeType: typeof(oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecOutputReference), fullyQualifiedName: "oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudMigrationsTargetAssetUserSpecOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudMigrationsTargetAssetUserSpecOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudMigrationsTargetAssetUserSpecOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudMigrationsTargetAssetUserSpecOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAgentConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecAgentConfig\"}}]")]
        public virtual void PutAgentConfig(oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecAgentConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecAgentConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCreateVnicDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecCreateVnicDetails\"}}]")]
        public virtual void PutCreateVnicDetails(oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecCreateVnicDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecCreateVnicDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInstanceOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecInstanceOptions\"}}]")]
        public virtual void PutInstanceOptions(oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecInstanceOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecInstanceOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPreemptibleInstanceConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfig\"}}]")]
        public virtual void PutPreemptibleInstanceConfig(oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShapeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecShapeConfig\"}}]")]
        public virtual void PutShapeConfig(oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecShapeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecShapeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecSourceDetails\"}}]")]
        public virtual void PutSourceDetails(oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecSourceDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecSourceDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAgentConfig")]
        public virtual void ResetAgentConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAvailabilityDomain")]
        public virtual void ResetAvailabilityDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapacityReservationId")]
        public virtual void ResetCapacityReservationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompartmentId")]
        public virtual void ResetCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateVnicDetails")]
        public virtual void ResetCreateVnicDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDedicatedVmHostId")]
        public virtual void ResetDedicatedVmHostId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFaultDomain")]
        public virtual void ResetFaultDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostnameLabel")]
        public virtual void ResetHostnameLabel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceOptions")]
        public virtual void ResetInstanceOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpxeScript")]
        public virtual void ResetIpxeScript()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsPvEncryptionInTransitEnabled")]
        public virtual void ResetIsPvEncryptionInTransitEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreemptibleInstanceConfig")]
        public virtual void ResetPreemptibleInstanceConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShape")]
        public virtual void ResetShape()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShapeConfig")]
        public virtual void ResetShapeConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceDetails")]
        public virtual void ResetSourceDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "agentConfig", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecAgentConfigOutputReference\"}")]
        public virtual oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecAgentConfigOutputReference AgentConfig
        {
            get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecAgentConfigOutputReference>()!;
        }

        [JsiiProperty(name: "createVnicDetails", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecCreateVnicDetailsOutputReference\"}")]
        public virtual oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecCreateVnicDetailsOutputReference CreateVnicDetails
        {
            get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecCreateVnicDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "instanceOptions", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecInstanceOptionsOutputReference\"}")]
        public virtual oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecInstanceOptionsOutputReference InstanceOptions
        {
            get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecInstanceOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "preemptibleInstanceConfig", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfigOutputReference\"}")]
        public virtual oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfigOutputReference PreemptibleInstanceConfig
        {
            get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfigOutputReference>()!;
        }

        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecShapeConfigOutputReference\"}")]
        public virtual oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecShapeConfigOutputReference ShapeConfig
        {
            get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecShapeConfigOutputReference>()!;
        }

        [JsiiProperty(name: "sourceDetails", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecSourceDetailsOutputReference\"}")]
        public virtual oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecSourceDetailsOutputReference SourceDetails
        {
            get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecSourceDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "agentConfigInput", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecAgentConfig\"}", isOptional: true)]
        public virtual oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecAgentConfig? AgentConfigInput
        {
            get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecAgentConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CapacityReservationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createVnicDetailsInput", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecCreateVnicDetails\"}", isOptional: true)]
        public virtual oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecCreateVnicDetails? CreateVnicDetailsInput
        {
            get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecCreateVnicDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dedicatedVmHostIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DedicatedVmHostIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "faultDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FaultDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostnameLabelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostnameLabelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceOptionsInput", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecInstanceOptions\"}", isOptional: true)]
        public virtual oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecInstanceOptions? InstanceOptionsInput
        {
            get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecInstanceOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipxeScriptInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpxeScriptInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isPvEncryptionInTransitEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsPvEncryptionInTransitEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preemptibleInstanceConfigInput", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfig\"}", isOptional: true)]
        public virtual oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfig? PreemptibleInstanceConfigInput
        {
            get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeConfigInput", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecShapeConfig\"}", isOptional: true)]
        public virtual oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecShapeConfig? ShapeConfigInput
        {
            get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecShapeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceDetailsInput", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecSourceDetails\"}", isOptional: true)]
        public virtual oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecSourceDetails? SourceDetailsInput
        {
            get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecSourceDetails?>();
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityReservationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dedicatedVmHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DedicatedVmHostId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FaultDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostnameLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostnameLabel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipxeScript", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpxeScript
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isPvEncryptionInTransitEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsPvEncryptionInTransitEnabled
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

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpec\"}", isOptional: true)]
        public virtual oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpec? InternalValue
        {
            get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpec?>();
            set => SetInstanceProperty(value);
        }
    }
}
