using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiClass(nativeType: typeof(oci.DisasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsOutputReference), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDestinationEncryptionKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsDestinationEncryptionKey\"}}]")]
        public virtual void PutDestinationEncryptionKey(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsDestinationEncryptionKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsDestinationEncryptionKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDestinationEncryptionKey")]
        public virtual void ResetDestinationEncryptionKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceVolumeId")]
        public virtual void ResetSourceVolumeId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "destinationEncryptionKey", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsDestinationEncryptionKeyOutputReference\"}")]
        public virtual oci.DisasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsDestinationEncryptionKeyOutputReference DestinationEncryptionKey
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsDestinationEncryptionKeyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationEncryptionKeyInput", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsDestinationEncryptionKey\"}", isOptional: true)]
        public virtual oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsDestinationEncryptionKey? DestinationEncryptionKeyInput
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsDestinationEncryptionKey?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceVolumeIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceVolumeIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "sourceVolumeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceVolumeId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappings\"}]}}", isOptional: true)]
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
                        case oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappings cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappings).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
