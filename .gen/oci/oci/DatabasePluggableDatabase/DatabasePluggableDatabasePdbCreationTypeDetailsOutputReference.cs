using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabasePluggableDatabase
{
    [JsiiClass(nativeType: typeof(oci.DatabasePluggableDatabase.DatabasePluggableDatabasePdbCreationTypeDetailsOutputReference), fullyQualifiedName: "oci.databasePluggableDatabase.DatabasePluggableDatabasePdbCreationTypeDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabasePluggableDatabasePdbCreationTypeDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabasePluggableDatabasePdbCreationTypeDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabasePluggableDatabasePdbCreationTypeDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabasePluggableDatabasePdbCreationTypeDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRefreshableCloneDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databasePluggableDatabase.DatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetails\"}}]")]
        public virtual void PutRefreshableCloneDetails(oci.DatabasePluggableDatabase.IDatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabasePluggableDatabase.IDatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDblinkUsername")]
        public virtual void ResetDblinkUsername()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDblinkUserPassword")]
        public virtual void ResetDblinkUserPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsThinClone")]
        public virtual void ResetIsThinClone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRefreshableCloneDetails")]
        public virtual void ResetRefreshableCloneDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceContainerDatabaseAdminPassword")]
        public virtual void ResetSourceContainerDatabaseAdminPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourcePluggableDatabaseSnapshotId")]
        public virtual void ResetSourcePluggableDatabaseSnapshotId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "refreshableCloneDetails", typeJson: "{\"fqn\":\"oci.databasePluggableDatabase.DatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetailsOutputReference\"}")]
        public virtual oci.DatabasePluggableDatabase.DatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetailsOutputReference RefreshableCloneDetails
        {
            get => GetInstanceProperty<oci.DatabasePluggableDatabase.DatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "creationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dblinkUsernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DblinkUsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dblinkUserPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DblinkUserPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isThinCloneInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsThinCloneInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "refreshableCloneDetailsInput", typeJson: "{\"fqn\":\"oci.databasePluggableDatabase.DatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetails\"}", isOptional: true)]
        public virtual oci.DatabasePluggableDatabase.IDatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetails? RefreshableCloneDetailsInput
        {
            get => GetInstanceProperty<oci.DatabasePluggableDatabase.IDatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceContainerDatabaseAdminPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceContainerDatabaseAdminPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourcePluggableDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourcePluggableDatabaseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourcePluggableDatabaseSnapshotIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourcePluggableDatabaseSnapshotIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "creationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dblinkUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DblinkUsername
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dblinkUserPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DblinkUserPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isThinClone", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsThinClone
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

        [JsiiProperty(name: "sourceContainerDatabaseAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceContainerDatabaseAdminPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourcePluggableDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourcePluggableDatabaseId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourcePluggableDatabaseSnapshotId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourcePluggableDatabaseSnapshotId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databasePluggableDatabase.DatabasePluggableDatabasePdbCreationTypeDetails\"}", isOptional: true)]
        public virtual oci.DatabasePluggableDatabase.IDatabasePluggableDatabasePdbCreationTypeDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatabasePluggableDatabase.IDatabasePluggableDatabasePdbCreationTypeDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
