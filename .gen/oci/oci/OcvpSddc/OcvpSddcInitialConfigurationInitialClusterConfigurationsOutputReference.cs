using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpSddc
{
    [JsiiClass(nativeType: typeof(oci.OcvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsOutputReference), fullyQualifiedName: "oci.ocvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class OcvpSddcInitialConfigurationInitialClusterConfigurationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public OcvpSddcInitialConfigurationInitialClusterConfigurationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected OcvpSddcInitialConfigurationInitialClusterConfigurationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OcvpSddcInitialConfigurationInitialClusterConfigurationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDatastores", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ocvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsDatastores\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDatastores(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.OcvpSddc.IOcvpSddcInitialConfigurationInitialClusterConfigurationsDatastores[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OcvpSddc.IOcvpSddcInitialConfigurationInitialClusterConfigurationsDatastores).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OcvpSddc.IOcvpSddcInitialConfigurationInitialClusterConfigurationsDatastores).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.ocvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsNetworkConfiguration\"}}]")]
        public virtual void PutNetworkConfiguration(oci.OcvpSddc.IOcvpSddcInitialConfigurationInitialClusterConfigurationsNetworkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OcvpSddc.IOcvpSddcInitialConfigurationInitialClusterConfigurationsNetworkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCapacityReservationId")]
        public virtual void ResetCapacityReservationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatastoreClusterIds")]
        public virtual void ResetDatastoreClusterIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatastores")]
        public virtual void ResetDatastores()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitialCommitment")]
        public virtual void ResetInitialCommitment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitialHostOcpuCount")]
        public virtual void ResetInitialHostOcpuCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitialHostShapeName")]
        public virtual void ResetInitialHostShapeName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceDisplayNamePrefix")]
        public virtual void ResetInstanceDisplayNamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsShieldedInstanceEnabled")]
        public virtual void ResetIsShieldedInstanceEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkConfiguration")]
        public virtual void ResetNetworkConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkloadNetworkCidr")]
        public virtual void ResetWorkloadNetworkCidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "actualEsxiHostsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ActualEsxiHostsCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "datastores", typeJson: "{\"fqn\":\"oci.ocvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsDatastoresList\"}")]
        public virtual oci.OcvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsDatastoresList Datastores
        {
            get => GetInstanceProperty<oci.OcvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsDatastoresList>()!;
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"oci.ocvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsNetworkConfigurationOutputReference\"}")]
        public virtual oci.OcvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsNetworkConfigurationOutputReference NetworkConfiguration
        {
            get => GetInstanceProperty<oci.OcvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsNetworkConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CapacityReservationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeAvailabilityDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeAvailabilityDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "datastoreClusterIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DatastoreClusterIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "datastoresInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ocvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsDatastores\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DatastoresInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "esxiHostsCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EsxiHostsCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialCommitmentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InitialCommitmentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialHostOcpuCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InitialHostOcpuCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialHostShapeNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InitialHostShapeNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceDisplayNamePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceDisplayNamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isShieldedInstanceEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsShieldedInstanceEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkConfigurationInput", typeJson: "{\"fqn\":\"oci.ocvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsNetworkConfiguration\"}", isOptional: true)]
        public virtual oci.OcvpSddc.IOcvpSddcInitialConfigurationInitialClusterConfigurationsNetworkConfiguration? NetworkConfigurationInput
        {
            get => GetInstanceProperty<oci.OcvpSddc.IOcvpSddcInitialConfigurationInitialClusterConfigurationsNetworkConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vsphereTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VsphereTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workloadNetworkCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkloadNetworkCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityReservationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computeAvailabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeAvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "datastoreClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DatastoreClusterIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "esxiHostsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EsxiHostsCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "initialCommitment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InitialCommitment
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "initialHostOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InitialHostOcpuCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "initialHostShapeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InitialHostShapeName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceDisplayNamePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceDisplayNamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isShieldedInstanceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsShieldedInstanceEnabled
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

        [JsiiProperty(name: "vsphereType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VsphereType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workloadNetworkCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkloadNetworkCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.ocvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurations\"}]}}", isOptional: true)]
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
                        case oci.OcvpSddc.IOcvpSddcInitialConfigurationInitialClusterConfigurations cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OcvpSddc.IOcvpSddcInitialConfigurationInitialClusterConfigurations).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
