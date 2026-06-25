using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabase
{
    [JsiiClass(nativeType: typeof(oci.DatabaseDatabase.DatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetailsOutputReference), fullyQualifiedName: "oci.databaseDatabase.DatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetTimeOfLastReadinessCheck")]
        public virtual void ResetTimeOfLastReadinessCheck()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeOfStatusUpdate")]
        public virtual void ResetTimeOfStatusUpdate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeScheduled")]
        public virtual void ResetTimeScheduled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpdateMode")]
        public virtual void ResetUpdateMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpdateReadinessStatus")]
        public virtual void ResetUpdateReadinessStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpdateReadinessStatusDetails")]
        public virtual void ResetUpdateReadinessStatusDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeOfLastReadinessCheckInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeOfLastReadinessCheckInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeOfStatusUpdateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeOfStatusUpdateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeScheduledInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeScheduledInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "updateModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UpdateModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "updateReadinessStatusDetailsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UpdateReadinessStatusDetailsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "updateReadinessStatusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UpdateReadinessStatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "timeOfLastReadinessCheck", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfLastReadinessCheck
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeOfStatusUpdate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfStatusUpdate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeScheduled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeScheduled
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "updateMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdateMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "updateReadinessStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdateReadinessStatus
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "updateReadinessStatusDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdateReadinessStatusDetails
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DatabaseDatabase.IDatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails\"}]}}", isOptional: true)]
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
                        case oci.DatabaseDatabase.IDatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseDatabase.IDatabaseDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
