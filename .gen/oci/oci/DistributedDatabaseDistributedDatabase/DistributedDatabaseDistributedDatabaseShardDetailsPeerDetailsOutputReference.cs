using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabase
{
    [JsiiClass(nativeType: typeof(oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsOutputReference), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDbStorageVaultDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsDbStorageVaultDetails\"}}]")]
        public virtual void PutDbStorageVaultDetails(oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsDbStorageVaultDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsDbStorageVaultDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVmClusterDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsVmClusterDetails\"}}]")]
        public virtual void PutVmClusterDetails(oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsVmClusterDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsVmClusterDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAvailabilityDomain")]
        public virtual void ResetAvailabilityDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbStorageVaultDetails")]
        public virtual void ResetDbStorageVaultDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtectionMode")]
        public virtual void ResetProtectionMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransportType")]
        public virtual void ResetTransportType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVmClusterDetails")]
        public virtual void ResetVmClusterDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVmClusterId")]
        public virtual void ResetVmClusterId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "containerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerDatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbStorageVaultDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsDbStorageVaultDetailsOutputReference\"}")]
        public virtual oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsDbStorageVaultDetailsOutputReference DbStorageVaultDetails
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsDbStorageVaultDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsMetadataList\"}")]
        public virtual oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsMetadataList>()!;
        }

        [JsiiProperty(name: "shardGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShardGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "supportingResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SupportingResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vmClusterDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsVmClusterDetailsOutputReference\"}")]
        public virtual oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsVmClusterDetailsOutputReference VmClusterDetails
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsVmClusterDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbStorageVaultDetailsInput", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsDbStorageVaultDetails\"}", isOptional: true)]
        public virtual oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsDbStorageVaultDetails? DbStorageVaultDetailsInput
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsDbStorageVaultDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protectionModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtectionModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transportTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TransportTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmClusterDetailsInput", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsVmClusterDetails\"}", isOptional: true)]
        public virtual oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsVmClusterDetails? VmClusterDetailsInput
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsVmClusterDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmClusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VmClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProtectionMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transportType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransportType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetails" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetails\"}]}}", isOptional: true)]
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
                        case oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetails cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetails).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
