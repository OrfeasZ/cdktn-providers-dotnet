using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightCustomPermissions
{
    [JsiiClass(nativeType: typeof(aws.QuicksightCustomPermissions.QuicksightCustomPermissionsCapabilitiesOutputReference), fullyQualifiedName: "aws.quicksightCustomPermissions.QuicksightCustomPermissionsCapabilitiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class QuicksightCustomPermissionsCapabilitiesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public QuicksightCustomPermissionsCapabilitiesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected QuicksightCustomPermissionsCapabilitiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightCustomPermissionsCapabilitiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAddOrRunAnomalyDetectionForAnalyses")]
        public virtual void ResetAddOrRunAnomalyDetectionForAnalyses()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateAndUpdateDashboardEmailReports")]
        public virtual void ResetCreateAndUpdateDashboardEmailReports()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateAndUpdateDatasets")]
        public virtual void ResetCreateAndUpdateDatasets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateAndUpdateDataSources")]
        public virtual void ResetCreateAndUpdateDataSources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateAndUpdateThemes")]
        public virtual void ResetCreateAndUpdateThemes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateAndUpdateThresholdAlerts")]
        public virtual void ResetCreateAndUpdateThresholdAlerts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateSharedFolders")]
        public virtual void ResetCreateSharedFolders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateSpiceDataset")]
        public virtual void ResetCreateSpiceDataset()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExportToCsv")]
        public virtual void ResetExportToCsv()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExportToCsvInScheduledReports")]
        public virtual void ResetExportToCsvInScheduledReports()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExportToExcel")]
        public virtual void ResetExportToExcel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExportToExcelInScheduledReports")]
        public virtual void ResetExportToExcelInScheduledReports()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExportToPdf")]
        public virtual void ResetExportToPdf()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExportToPdfInScheduledReports")]
        public virtual void ResetExportToPdfInScheduledReports()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncludeContentInScheduledReportsEmail")]
        public virtual void ResetIncludeContentInScheduledReportsEmail()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrintReports")]
        public virtual void ResetPrintReports()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRenameSharedFolders")]
        public virtual void ResetRenameSharedFolders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShareAnalyses")]
        public virtual void ResetShareAnalyses()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShareDashboards")]
        public virtual void ResetShareDashboards()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShareDatasets")]
        public virtual void ResetShareDatasets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShareDataSources")]
        public virtual void ResetShareDataSources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubscribeDashboardEmailReports")]
        public virtual void ResetSubscribeDashboardEmailReports()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetViewAccountSpiceCapacity")]
        public virtual void ResetViewAccountSpiceCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "addOrRunAnomalyDetectionForAnalysesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AddOrRunAnomalyDetectionForAnalysesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createAndUpdateDashboardEmailReportsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreateAndUpdateDashboardEmailReportsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createAndUpdateDatasetsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreateAndUpdateDatasetsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createAndUpdateDataSourcesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreateAndUpdateDataSourcesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createAndUpdateThemesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreateAndUpdateThemesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createAndUpdateThresholdAlertsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreateAndUpdateThresholdAlertsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createSharedFoldersInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreateSharedFoldersInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createSpiceDatasetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreateSpiceDatasetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportToCsvInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExportToCsvInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportToCsvInScheduledReportsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExportToCsvInScheduledReportsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportToExcelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExportToExcelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportToExcelInScheduledReportsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExportToExcelInScheduledReportsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportToPdfInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExportToPdfInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportToPdfInScheduledReportsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExportToPdfInScheduledReportsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeContentInScheduledReportsEmailInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IncludeContentInScheduledReportsEmailInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "printReportsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrintReportsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "renameSharedFoldersInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RenameSharedFoldersInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shareAnalysesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShareAnalysesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shareDashboardsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShareDashboardsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shareDatasetsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShareDatasetsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shareDataSourcesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShareDataSourcesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subscribeDashboardEmailReportsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubscribeDashboardEmailReportsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "viewAccountSpiceCapacityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ViewAccountSpiceCapacityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "addOrRunAnomalyDetectionForAnalyses", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddOrRunAnomalyDetectionForAnalyses
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "createAndUpdateDashboardEmailReports", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreateAndUpdateDashboardEmailReports
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "createAndUpdateDatasets", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreateAndUpdateDatasets
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "createAndUpdateDataSources", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreateAndUpdateDataSources
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "createAndUpdateThemes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreateAndUpdateThemes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "createAndUpdateThresholdAlerts", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreateAndUpdateThresholdAlerts
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "createSharedFolders", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreateSharedFolders
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "createSpiceDataset", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreateSpiceDataset
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "exportToCsv", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExportToCsv
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "exportToCsvInScheduledReports", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExportToCsvInScheduledReports
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "exportToExcel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExportToExcel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "exportToExcelInScheduledReports", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExportToExcelInScheduledReports
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "exportToPdf", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExportToPdf
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "exportToPdfInScheduledReports", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExportToPdfInScheduledReports
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "includeContentInScheduledReportsEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IncludeContentInScheduledReportsEmail
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "printReports", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrintReports
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "renameSharedFolders", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RenameSharedFolders
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shareAnalyses", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShareAnalyses
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shareDashboards", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShareDashboards
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shareDatasets", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShareDatasets
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shareDataSources", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShareDataSources
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subscribeDashboardEmailReports", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscribeDashboardEmailReports
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "viewAccountSpiceCapacity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ViewAccountSpiceCapacity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.quicksightCustomPermissions.QuicksightCustomPermissionsCapabilities\"}]}}", isOptional: true)]
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
                        case aws.QuicksightCustomPermissions.IQuicksightCustomPermissionsCapabilities cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.QuicksightCustomPermissions.IQuicksightCustomPermissionsCapabilities).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
