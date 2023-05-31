import BootstrapTable, { BootstrapTableProps } from "react-bootstrap-table-next";
import paginationFactory from "react-bootstrap-table2-paginator";
import { TableContainer } from "./style";

const paginationOptions = {
    sizePerPage: 50,
    hideSizePerPage: true, 
  };
  

export default function Table(props: BootstrapTableProps) {

    return (
        <TableContainer>
            <BootstrapTable
                {...props}
                keyField='vacina'
                striped
                pagination={paginationFactory(paginationOptions)}
            />
        </TableContainer>
    );
}
