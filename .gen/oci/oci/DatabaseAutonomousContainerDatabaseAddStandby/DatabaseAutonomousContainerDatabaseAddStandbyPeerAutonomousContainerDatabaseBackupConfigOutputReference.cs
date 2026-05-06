using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousContainerDatabaseAddStandby
{
    [JsiiClass(nativeType: typeof(oci.DatabaseAutonomousContainerDatabaseAddStandby.DatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfigOutputReference), fullyQualifiedName: "oci.databaseAutonomousContainerDatabaseAddStandby.DatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBackupDestinationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseAutonomousContainerDatabaseAddStandby.DatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfigBackupDestinationDetails\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutBackupDestinationDetails(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatabaseAutonomousContainerDatabaseAddStandby.IDatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfigBackupDestinationDetails[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseAutonomousContainerDatabaseAddStandby.IDatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfigBackupDestinationDetails).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseAutonomousContainerDatabaseAddStandby.IDatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfigBackupDestinationDetails).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBackupDestinationDetails")]
        public virtual void ResetBackupDestinationDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecoveryWindowInDays")]
        public virtual void ResetRecoveryWindowInDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "backupDestinationDetails", typeJson: "{\"fqn\":\"oci.databaseAutonomousContainerDatabaseAddStandby.DatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfigBackupDestinationDetailsList\"}")]
        public virtual oci.DatabaseAutonomousContainerDatabaseAddStandby.DatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfigBackupDestinationDetailsList BackupDestinationDetails
        {
            get => GetInstanceProperty<oci.DatabaseAutonomousContainerDatabaseAddStandby.DatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfigBackupDestinationDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupDestinationDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseAutonomousContainerDatabaseAddStandby.DatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfigBackupDestinationDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? BackupDestinationDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recoveryWindowInDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RecoveryWindowInDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "recoveryWindowInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RecoveryWindowInDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseAutonomousContainerDatabaseAddStandby.DatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfig\"}", isOptional: true)]
        public virtual oci.DatabaseAutonomousContainerDatabaseAddStandby.IDatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseAutonomousContainerDatabaseAddStandby.IDatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
