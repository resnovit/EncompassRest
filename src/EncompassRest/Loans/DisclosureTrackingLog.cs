#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class DisclosureTrackingLog : ExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyValue<string> _alertsXml;
        public string AlertsXml { get => _alertsXml; set => _alertsXml = value; }
        private DirtyValue<DateTime?> _applicationDate;
        public DateTime? ApplicationDate { get => _applicationDate; set => _applicationDate = value; }
        private DirtyValue<string> _borrowerName;
        public string BorrowerName { get => _borrowerName; set => _borrowerName = value; }
        private DirtyValue<string> _borrowerPairId;
        public string BorrowerPairId { get => _borrowerPairId; set => _borrowerPairId = value; }
        private DirtyValue<string> _coBorrowerName;
        public string CoBorrowerName { get => _coBorrowerName; set => _coBorrowerName = value; }
        private DirtyList<LogComment> _commentList;
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _commentListXml;
        public string CommentListXml { get => _commentListXml; set => _commentListXml = value; }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<bool?> _containGfe;
        public bool? ContainGfe { get => _containGfe; set => _containGfe = value; }
        private DirtyValue<bool?> _containSafeHarbor;
        public bool? ContainSafeHarbor { get => _containSafeHarbor; set => _containSafeHarbor = value; }
        private DirtyValue<bool?> _containTil;
        public bool? ContainTil { get => _containTil; set => _containTil = value; }
        private DirtyValue<DateTime?> _dateUtc;
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<string> _disclosedAPR;
        public string DisclosedAPR { get => _disclosedAPR; set => _disclosedAPR = value; }
        private DirtyValue<string> _disclosedBy;
        public string DisclosedBy { get => _disclosedBy; set => _disclosedBy = value; }
        private DirtyValue<string> _disclosedByFullName;
        public string DisclosedByFullName { get => _disclosedByFullName; set => _disclosedByFullName = value; }
        private DirtyValue<string> _disclosedMethod;
        public string DisclosedMethod { get => _disclosedMethod; set => _disclosedMethod = value; }
        private DirtyValue<DateTime?> _disclosureCreatedDttmUtc;
        public DateTime? DisclosureCreatedDttmUtc { get => _disclosureCreatedDttmUtc; set => _disclosureCreatedDttmUtc = value; }
        private DirtyValue<bool?> _eDisclosureApplicationPackageIndicator;
        public bool? EDisclosureApplicationPackageIndicator { get => _eDisclosureApplicationPackageIndicator; set => _eDisclosureApplicationPackageIndicator = value; }
        private DirtyValue<bool?> _eDisclosureApprovalPackageIndicator;
        public bool? EDisclosureApprovalPackageIndicator { get => _eDisclosureApprovalPackageIndicator; set => _eDisclosureApprovalPackageIndicator = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowerAcceptConsentDate;
        public DateTime? EDisclosureBorrowerAcceptConsentDate { get => _eDisclosureBorrowerAcceptConsentDate; set => _eDisclosureBorrowerAcceptConsentDate = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowereSignedDate;
        public DateTime? EDisclosureBorrowereSignedDate { get => _eDisclosureBorrowereSignedDate; set => _eDisclosureBorrowereSignedDate = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowerRejectConsentDate;
        public DateTime? EDisclosureBorrowerRejectConsentDate { get => _eDisclosureBorrowerRejectConsentDate; set => _eDisclosureBorrowerRejectConsentDate = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowerViewConsentDate;
        public DateTime? EDisclosureBorrowerViewConsentDate { get => _eDisclosureBorrowerViewConsentDate; set => _eDisclosureBorrowerViewConsentDate = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowerViewMessageDate;
        public DateTime? EDisclosureBorrowerViewMessageDate { get => _eDisclosureBorrowerViewMessageDate; set => _eDisclosureBorrowerViewMessageDate = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowerWetSignedDate;
        public DateTime? EDisclosureBorrowerWetSignedDate { get => _eDisclosureBorrowerWetSignedDate; set => _eDisclosureBorrowerWetSignedDate = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerAcceptConsentDate;
        public DateTime? EDisclosureCoBorrowerAcceptConsentDate { get => _eDisclosureCoBorrowerAcceptConsentDate; set => _eDisclosureCoBorrowerAcceptConsentDate = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowereSignedDate;
        public DateTime? EDisclosureCoBorrowereSignedDate { get => _eDisclosureCoBorrowereSignedDate; set => _eDisclosureCoBorrowereSignedDate = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerRejectConsentDate;
        public DateTime? EDisclosureCoBorrowerRejectConsentDate { get => _eDisclosureCoBorrowerRejectConsentDate; set => _eDisclosureCoBorrowerRejectConsentDate = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerViewConsentDate;
        public DateTime? EDisclosureCoBorrowerViewConsentDate { get => _eDisclosureCoBorrowerViewConsentDate; set => _eDisclosureCoBorrowerViewConsentDate = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerViewMessageDate;
        public DateTime? EDisclosureCoBorrowerViewMessageDate { get => _eDisclosureCoBorrowerViewMessageDate; set => _eDisclosureCoBorrowerViewMessageDate = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerWebSignedDate;
        public DateTime? EDisclosureCoBorrowerWebSignedDate { get => _eDisclosureCoBorrowerWebSignedDate; set => _eDisclosureCoBorrowerWebSignedDate = value; }
        private DirtyValue<string> _eDisclosureConsentPdf;
        public string EDisclosureConsentPdf { get => _eDisclosureConsentPdf; set => _eDisclosureConsentPdf = value; }
        private DirtyValue<string> _eDisclosureDisclosedMessage;
        public string EDisclosureDisclosedMessage { get => _eDisclosureDisclosedMessage; set => _eDisclosureDisclosedMessage = value; }
        private DirtyValue<bool?> _eDisclosureLockPackageIndicator;
        public bool? EDisclosureLockPackageIndicator { get => _eDisclosureLockPackageIndicator; set => _eDisclosureLockPackageIndicator = value; }
        private DirtyValue<string> _eDisclosureManualFulfillmentComment;
        public string EDisclosureManualFulfillmentComment { get => _eDisclosureManualFulfillmentComment; set => _eDisclosureManualFulfillmentComment = value; }
        private DirtyValue<DateTime?> _eDisclosureManualFulfillmentDate;
        public DateTime? EDisclosureManualFulfillmentDate { get => _eDisclosureManualFulfillmentDate; set => _eDisclosureManualFulfillmentDate = value; }
        private DirtyValue<string> _eDisclosureManualFulfillmentMethod;
        public string EDisclosureManualFulfillmentMethod { get => _eDisclosureManualFulfillmentMethod; set => _eDisclosureManualFulfillmentMethod = value; }
        private DirtyValue<string> _eDisclosureManuallyFulfilledBy;
        public string EDisclosureManuallyFulfilledBy { get => _eDisclosureManuallyFulfilledBy; set => _eDisclosureManuallyFulfilledBy = value; }
        private DirtyValue<DateTime?> _eDisclosurePackageCreatedDate;
        public DateTime? EDisclosurePackageCreatedDate { get => _eDisclosurePackageCreatedDate; set => _eDisclosurePackageCreatedDate = value; }
        private DirtyValue<string> _eDisclosurePackageId;
        public string EDisclosurePackageId { get => _eDisclosurePackageId; set => _eDisclosurePackageId = value; }
        private DirtyValue<string> _eDisclosurePackageViewableFile;
        public string EDisclosurePackageViewableFile { get => _eDisclosurePackageViewableFile; set => _eDisclosurePackageViewableFile = value; }
        private DirtyValue<bool?> _eDisclosureThreeDayPackageIndicator;
        public bool? EDisclosureThreeDayPackageIndicator { get => _eDisclosureThreeDayPackageIndicator; set => _eDisclosureThreeDayPackageIndicator = value; }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _financeCharge;
        public string FinanceCharge { get => _financeCharge; set => _financeCharge = value; }
        private DirtyList<DisclosureForm> _forms;
        public IList<DisclosureForm> Forms { get => _forms ?? (_forms = new DirtyList<DisclosureForm>()); set => _forms = new DirtyList<DisclosureForm>(value); }
        private DirtyValue<string> _formsXml;
        public string FormsXml { get => _formsXml; set => _formsXml = value; }
        private DirtyValue<string> _fulfillmentOrderedBy;
        public string FulfillmentOrderedBy { get => _fulfillmentOrderedBy; set => _fulfillmentOrderedBy = value; }
        private DirtyValue<string> _fullfillmentProcessedDate;
        public string FullfillmentProcessedDate { get => _fullfillmentProcessedDate; set => _fullfillmentProcessedDate = value; }
        private DirtyValue<string> _guid;
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _isDisclosed;
        public string IsDisclosed { get => _isDisclosed; set => _isDisclosed = value; }
        private DirtyValue<string> _isDisclosedAprLocked;
        public string IsDisclosedAprLocked { get => _isDisclosedAprLocked; set => _isDisclosedAprLocked = value; }
        private DirtyValue<string> _isDisclosedByLocked;
        public string IsDisclosedByLocked { get => _isDisclosedByLocked; set => _isDisclosedByLocked = value; }
        private DirtyValue<string> _isDisclosedFinanceChargeLocked;
        public string IsDisclosedFinanceChargeLocked { get => _isDisclosedFinanceChargeLocked; set => _isDisclosedFinanceChargeLocked = value; }
        private DirtyValue<string> _isDisclosedReceivedDateLocked;
        public string IsDisclosedReceivedDateLocked { get => _isDisclosedReceivedDateLocked; set => _isDisclosedReceivedDateLocked = value; }
        private DirtyValue<string> _isLocked;
        public string IsLocked { get => _isLocked; set => _isLocked = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<bool?> _isWetSignedIndicator;
        public bool? IsWetSignedIndicator { get => _isWetSignedIndicator; set => _isWetSignedIndicator = value; }
        private DirtyValue<string> _loanAmount;
        public string LoanAmount { get => _loanAmount; set => _loanAmount = value; }
        private DirtyValue<string> _loanProgram;
        public string LoanProgram { get => _loanProgram; set => _loanProgram = value; }
        private DirtyValue<string> _lockedDisclosedAprField;
        public string LockedDisclosedAprField { get => _lockedDisclosedAprField; set => _lockedDisclosedAprField = value; }
        private DirtyValue<string> _lockedDisclosedByField;
        public string LockedDisclosedByField { get => _lockedDisclosedByField; set => _lockedDisclosedByField = value; }
        private DirtyValue<string> _lockedDisclosedFinanceChargeField;
        public string LockedDisclosedFinanceChargeField { get => _lockedDisclosedFinanceChargeField; set => _lockedDisclosedFinanceChargeField = value; }
        private DirtyValue<DateTime?> _lockedDisclosedReceivedDate;
        public DateTime? LockedDisclosedReceivedDate { get => _lockedDisclosedReceivedDate; set => _lockedDisclosedReceivedDate = value; }
        private DirtyValue<int?> _logRecordIndex;
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<string> _manuallyCreated;
        public string ManuallyCreated { get => _manuallyCreated; set => _manuallyCreated = value; }
        private DirtyValue<string> _propertyAddress;
        public string PropertyAddress { get => _propertyAddress; set => _propertyAddress = value; }
        private DirtyValue<string> _propertyCity;
        public string PropertyCity { get => _propertyCity; set => _propertyCity = value; }
        private DirtyValue<string> _propertyState;
        public string PropertyState { get => _propertyState; set => _propertyState = value; }
        private DirtyValue<string> _propertyZip;
        public string PropertyZip { get => _propertyZip; set => _propertyZip = value; }
        private DirtyValue<DateTime?> _receivedDate;
        public DateTime? ReceivedDate { get => _receivedDate; set => _receivedDate = value; }
        private DirtyList<LogSnapshotField> _snapshotFields;
        public IList<LogSnapshotField> SnapshotFields { get => _snapshotFields ?? (_snapshotFields = new DirtyList<LogSnapshotField>()); set => _snapshotFields = new DirtyList<LogSnapshotField>(value); }
        private DirtyValue<string> _snapshotXml;
        public string SnapshotXml { get => _snapshotXml; set => _snapshotXml = value; }
        private DirtyValue<string> _systemId;
        public string SystemId { get => _systemId; set => _systemId = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _alertsXml.Dirty
                    || _applicationDate.Dirty
                    || _borrowerName.Dirty
                    || _borrowerPairId.Dirty
                    || _coBorrowerName.Dirty
                    || _commentListXml.Dirty
                    || _comments.Dirty
                    || _containGfe.Dirty
                    || _containSafeHarbor.Dirty
                    || _containTil.Dirty
                    || _dateUtc.Dirty
                    || _disclosedAPR.Dirty
                    || _disclosedBy.Dirty
                    || _disclosedByFullName.Dirty
                    || _disclosedMethod.Dirty
                    || _disclosureCreatedDttmUtc.Dirty
                    || _eDisclosureApplicationPackageIndicator.Dirty
                    || _eDisclosureApprovalPackageIndicator.Dirty
                    || _eDisclosureBorrowerAcceptConsentDate.Dirty
                    || _eDisclosureBorrowereSignedDate.Dirty
                    || _eDisclosureBorrowerRejectConsentDate.Dirty
                    || _eDisclosureBorrowerViewConsentDate.Dirty
                    || _eDisclosureBorrowerViewMessageDate.Dirty
                    || _eDisclosureBorrowerWetSignedDate.Dirty
                    || _eDisclosureCoBorrowerAcceptConsentDate.Dirty
                    || _eDisclosureCoBorrowereSignedDate.Dirty
                    || _eDisclosureCoBorrowerRejectConsentDate.Dirty
                    || _eDisclosureCoBorrowerViewConsentDate.Dirty
                    || _eDisclosureCoBorrowerViewMessageDate.Dirty
                    || _eDisclosureCoBorrowerWebSignedDate.Dirty
                    || _eDisclosureConsentPdf.Dirty
                    || _eDisclosureDisclosedMessage.Dirty
                    || _eDisclosureLockPackageIndicator.Dirty
                    || _eDisclosureManualFulfillmentComment.Dirty
                    || _eDisclosureManualFulfillmentDate.Dirty
                    || _eDisclosureManualFulfillmentMethod.Dirty
                    || _eDisclosureManuallyFulfilledBy.Dirty
                    || _eDisclosurePackageCreatedDate.Dirty
                    || _eDisclosurePackageId.Dirty
                    || _eDisclosurePackageViewableFile.Dirty
                    || _eDisclosureThreeDayPackageIndicator.Dirty
                    || _fileAttachmentsMigrated.Dirty
                    || _financeCharge.Dirty
                    || _formsXml.Dirty
                    || _fulfillmentOrderedBy.Dirty
                    || _fullfillmentProcessedDate.Dirty
                    || _guid.Dirty
                    || _id.Dirty
                    || _isDisclosed.Dirty
                    || _isDisclosedAprLocked.Dirty
                    || _isDisclosedByLocked.Dirty
                    || _isDisclosedFinanceChargeLocked.Dirty
                    || _isDisclosedReceivedDateLocked.Dirty
                    || _isLocked.Dirty
                    || _isSystemSpecificIndicator.Dirty
                    || _isWetSignedIndicator.Dirty
                    || _loanAmount.Dirty
                    || _loanProgram.Dirty
                    || _lockedDisclosedAprField.Dirty
                    || _lockedDisclosedByField.Dirty
                    || _lockedDisclosedFinanceChargeField.Dirty
                    || _lockedDisclosedReceivedDate.Dirty
                    || _logRecordIndex.Dirty
                    || _manuallyCreated.Dirty
                    || _propertyAddress.Dirty
                    || _propertyCity.Dirty
                    || _propertyState.Dirty
                    || _propertyZip.Dirty
                    || _receivedDate.Dirty
                    || _snapshotXml.Dirty
                    || _systemId.Dirty
                    || _alerts?.Dirty == true
                    || _commentList?.Dirty == true
                    || _forms?.Dirty == true
                    || _snapshotFields?.Dirty == true;
            }
            set
            {
                _alertsXml.Dirty = value;
                _applicationDate.Dirty = value;
                _borrowerName.Dirty = value;
                _borrowerPairId.Dirty = value;
                _coBorrowerName.Dirty = value;
                _commentListXml.Dirty = value;
                _comments.Dirty = value;
                _containGfe.Dirty = value;
                _containSafeHarbor.Dirty = value;
                _containTil.Dirty = value;
                _dateUtc.Dirty = value;
                _disclosedAPR.Dirty = value;
                _disclosedBy.Dirty = value;
                _disclosedByFullName.Dirty = value;
                _disclosedMethod.Dirty = value;
                _disclosureCreatedDttmUtc.Dirty = value;
                _eDisclosureApplicationPackageIndicator.Dirty = value;
                _eDisclosureApprovalPackageIndicator.Dirty = value;
                _eDisclosureBorrowerAcceptConsentDate.Dirty = value;
                _eDisclosureBorrowereSignedDate.Dirty = value;
                _eDisclosureBorrowerRejectConsentDate.Dirty = value;
                _eDisclosureBorrowerViewConsentDate.Dirty = value;
                _eDisclosureBorrowerViewMessageDate.Dirty = value;
                _eDisclosureBorrowerWetSignedDate.Dirty = value;
                _eDisclosureCoBorrowerAcceptConsentDate.Dirty = value;
                _eDisclosureCoBorrowereSignedDate.Dirty = value;
                _eDisclosureCoBorrowerRejectConsentDate.Dirty = value;
                _eDisclosureCoBorrowerViewConsentDate.Dirty = value;
                _eDisclosureCoBorrowerViewMessageDate.Dirty = value;
                _eDisclosureCoBorrowerWebSignedDate.Dirty = value;
                _eDisclosureConsentPdf.Dirty = value;
                _eDisclosureDisclosedMessage.Dirty = value;
                _eDisclosureLockPackageIndicator.Dirty = value;
                _eDisclosureManualFulfillmentComment.Dirty = value;
                _eDisclosureManualFulfillmentDate.Dirty = value;
                _eDisclosureManualFulfillmentMethod.Dirty = value;
                _eDisclosureManuallyFulfilledBy.Dirty = value;
                _eDisclosurePackageCreatedDate.Dirty = value;
                _eDisclosurePackageId.Dirty = value;
                _eDisclosurePackageViewableFile.Dirty = value;
                _eDisclosureThreeDayPackageIndicator.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _financeCharge.Dirty = value;
                _formsXml.Dirty = value;
                _fulfillmentOrderedBy.Dirty = value;
                _fullfillmentProcessedDate.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _isDisclosed.Dirty = value;
                _isDisclosedAprLocked.Dirty = value;
                _isDisclosedByLocked.Dirty = value;
                _isDisclosedFinanceChargeLocked.Dirty = value;
                _isDisclosedReceivedDateLocked.Dirty = value;
                _isLocked.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _isWetSignedIndicator.Dirty = value;
                _loanAmount.Dirty = value;
                _loanProgram.Dirty = value;
                _lockedDisclosedAprField.Dirty = value;
                _lockedDisclosedByField.Dirty = value;
                _lockedDisclosedFinanceChargeField.Dirty = value;
                _lockedDisclosedReceivedDate.Dirty = value;
                _logRecordIndex.Dirty = value;
                _manuallyCreated.Dirty = value;
                _propertyAddress.Dirty = value;
                _propertyCity.Dirty = value;
                _propertyState.Dirty = value;
                _propertyZip.Dirty = value;
                _receivedDate.Dirty = value;
                _snapshotXml.Dirty = value;
                _systemId.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
                if (_forms != null) _forms.Dirty = value;
                if (_snapshotFields != null) _snapshotFields.Dirty = value;
            }
        }
    }
}