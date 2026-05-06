using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiClass(nativeType: typeof(oci.DisasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsOutputReference), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMountDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsMountDetails\"}}]")]
        public virtual void PutMountDetails(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersFileSystemOperationsMountDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersFileSystemOperationsMountDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUnmountDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetails\"}}]")]
        public virtual void PutUnmountDetails(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExportPath")]
        public virtual void ResetExportPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMountDetails")]
        public virtual void ResetMountDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMountPoint")]
        public virtual void ResetMountPoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMountTargetId")]
        public virtual void ResetMountTargetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUnmountDetails")]
        public virtual void ResetUnmountDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "mountDetails", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsMountDetailsOutputReference\"}")]
        public virtual oci.DisasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsMountDetailsOutputReference MountDetails
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsMountDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "unmountDetails", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetailsOutputReference\"}")]
        public virtual oci.DisasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetailsOutputReference UnmountDetails
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExportPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mountDetailsInput", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsMountDetails\"}", isOptional: true)]
        public virtual oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersFileSystemOperationsMountDetails? MountDetailsInput
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersFileSystemOperationsMountDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mountPointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MountPointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mountTargetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MountTargetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "unmountDetailsInput", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetails\"}", isOptional: true)]
        public virtual oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetails? UnmountDetailsInput
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetails?>();
        }

        [JsiiProperty(name: "exportPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExportPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mountPoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MountPoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mountTargetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MountTargetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperations\"}]}}", isOptional: true)]
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
                        case oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersFileSystemOperations cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersFileSystemOperations).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
