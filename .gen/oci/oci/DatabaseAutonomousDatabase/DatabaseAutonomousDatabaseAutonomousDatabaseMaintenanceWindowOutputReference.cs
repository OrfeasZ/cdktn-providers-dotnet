using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabase
{
    [JsiiClass(nativeType: typeof(oci.DatabaseAutonomousDatabase.DatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowOutputReference), fullyQualifiedName: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDayOfWeek", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowDayOfWeek\"}}]")]
        public virtual void PutDayOfWeek(oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowDayOfWeek @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowDayOfWeek)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAvailabilityDomain")]
        public virtual void ResetAvailabilityDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsMaintenanceWindowChangeScheduled")]
        public virtual void ResetIsMaintenanceWindowChangeScheduled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceEndTime")]
        public virtual void ResetMaintenanceEndTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceStartTime")]
        public virtual void ResetMaintenanceStartTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"fqn\":\"oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowDayOfWeekOutputReference\"}")]
        public virtual oci.DatabaseAutonomousDatabase.DatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowDayOfWeekOutputReference DayOfWeek
        {
            get => GetInstanceProperty<oci.DatabaseAutonomousDatabase.DatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowDayOfWeekOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dayOfWeekInput", typeJson: "{\"fqn\":\"oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowDayOfWeek\"}", isOptional: true)]
        public virtual oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowDayOfWeek? DayOfWeekInput
        {
            get => GetInstanceProperty<oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowDayOfWeek?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isMaintenanceWindowChangeScheduledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsMaintenanceWindowChangeScheduledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceEndTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaintenanceEndTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceStartTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaintenanceStartTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isMaintenanceWindowChangeScheduled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsMaintenanceWindowChangeScheduled
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

        [JsiiProperty(name: "maintenanceEndTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceEndTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maintenanceStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceStartTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindow\"}", isOptional: true)]
        public virtual oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindow? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindow?>();
            set => SetInstanceProperty(value);
        }
    }
}
